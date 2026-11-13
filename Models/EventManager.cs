using Community_Watcher.Models;
using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Community_Watcher.Models
{
    public class EventManager
    {
        private const int MaxRecentSearches = 5;

        // Master list
        private readonly List<Event> allEvents = new List<Event>();

        // Sorted dictionary: events ordered by date
        private readonly SortedDictionary<DateTime, List<Event>> eventsByDate =
            new SortedDictionary<DateTime, List<Event>>();

        // Dictionary (hash table): fast lookup by category
        private readonly Dictionary<string, List<Event>> eventsByCategory =
            new Dictionary<string, List<Event>>(StringComparer.OrdinalIgnoreCase);

        // Sets: unique categories, unique dates, and viewed event ids
        private readonly HashSet<string> categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<DateTime> uniqueDates = new HashSet<DateTime>();
        private readonly HashSet<int> viewedIds = new HashSet<int>();

        // Stack: recently viewed events (most recent first)
        private readonly Stack<Event> viewHistory = new Stack<Event>();

        // Queue: last few searches (oldest removed first)
        private readonly Queue<string> recentSearches = new Queue<string>();

        // Dictionary: how interested the user is in each category
        private readonly Dictionary<string, int> categoryScores =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        public int UniqueDateCount => uniqueDates.Count;

        public void LoadEvents(IEnumerable<Event> events)
        {
            foreach (Event e in events)
                AddEvent(e);
        }

        public void AddEvent(Event e)
        {
            allEvents.Add(e);

            DateTime day = e.Date.Date;
            if (!eventsByDate.ContainsKey(day))
                eventsByDate[day] = new List<Event>();
            eventsByDate[day].Add(e);

            if (!eventsByCategory.ContainsKey(e.Category))
                eventsByCategory[e.Category] = new List<Event>();
            eventsByCategory[e.Category].Add(e);

            categories.Add(e.Category);
            uniqueDates.Add(day);
        }

        public int GetNextId()
        {
            return allEvents.Count == 0 ? 1 : allEvents.Max(x => x.Id) + 1;
        }

        public List<string> GetCategories()
        {
            return categories.OrderBy(c => c).ToList();
        }

        // Standard Search
        public List<Event> Search(string category, DateTime from, DateTime to)
        {
            DateTime start = from.Date;
            DateTime end = to.Date;
            List<Event> results = new List<Event>();

            if (string.IsNullOrEmpty(category) || category.Equals("All Categories", StringComparison.OrdinalIgnoreCase))
            {
                foreach (KeyValuePair<DateTime, List<Event>> pair in eventsByDate)
                {
                    if (pair.Key < start) continue;
                    if (pair.Key > end) break;
                    results.AddRange(pair.Value);
                }
            }
            else if (eventsByCategory.TryGetValue(category, out List<Event> list))
            {
                results = list
                    .Where(e => e.Date.Date >= start && e.Date.Date <= end)
                    .OrderBy(e => e.Date)
                    .ToList();
            }

            return results;
        }

        // Wrapper methods matching form calls
        public List<Event> SearchByDateRange(DateTime from, DateTime to)
        {
            return Search(string.Empty, from, to);
        }

        public List<Event> SearchByCategoryAndDate(string category, DateTime from, DateTime to)
        {
            return Search(category, from, to);
        }

        public List<Event> GetUrgentAnnouncements(int count = 5)
        {
            return GetUrgent(count);
        }

        public void RecordSearch(string category)
        {
            string label = string.IsNullOrEmpty(category) ? "All categories" : category;

            recentSearches.Enqueue(label);
            while (recentSearches.Count > MaxRecentSearches)
                recentSearches.Dequeue();

            if (!string.IsNullOrEmpty(category) && !category.Equals("All Categories", StringComparison.OrdinalIgnoreCase))
                AddScore(category, 3);
        }

        public void RecordView(Event e)
        {
            viewedIds.Add(e.Id);

            if (viewHistory.Count == 0 || viewHistory.Peek().Id != e.Id)
                viewHistory.Push(e);

            AddScore(e.Category, 1);
        }

        private void AddScore(string category, int points)
        {
            categoryScores.TryGetValue(category, out int current);
            categoryScores[category] = current + points;
        }

        public string GetRecentSearchesText()
        {
            return recentSearches.Count == 0 ? "none" : string.Join(", ", recentSearches);
        }

        public List<Event> GetRecentlyViewed(int count)
        {
            return viewHistory.Take(count).ToList();
        }

        public List<Event> GetUrgent(int count)
        {
            PriorityQueue<Event, (int, DateTime)> queue = new PriorityQueue<Event, (int, DateTime)>();

            foreach (Event e in allEvents)
            {
                if (e.Date.Date >= DateTime.Today && e.Priority <= 2)
                    queue.Enqueue(e, (e.Priority, e.Date));
            }

            List<Event> result = new List<Event>();
            while (result.Count < count && queue.Count > 0)
                result.Add(queue.Dequeue());
            return result;
        }

        public List<Event> GetRecommendations(int count = 5)
        {
            PriorityQueue<Event, int> queue = new PriorityQueue<Event, int>();

            foreach (Event e in allEvents)
            {
                int daysAway = (e.Date.Date - DateTime.Today).Days;
                if (daysAway < 0 || viewedIds.Contains(e.Id))
                    continue;

                categoryScores.TryGetValue(e.Category, out int preference);
                int proximity = Math.Max(0, 30 - daysAway);
                int score = preference * 10 + proximity;
                if (e.Priority == 1) score += 5;

                queue.Enqueue(e, -score);
            }

            List<Event> result = new List<Event>();
            while (result.Count < count && queue.Count > 0)
                result.Add(queue.Dequeue());
            return result;
        }

        public string GetRecommendationReason(Event e)
        {
            if (categoryScores.TryGetValue(e.Category, out int pref) && pref > 0)
                return "Matches your interest in " + e.Category;
            return "Happening soon";
        }
    }
}