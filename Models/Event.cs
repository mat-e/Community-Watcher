using System;
using System.Collections.Generic;

namespace MunicipalServicesApp
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Priority { get; set; } = 3;   // 1 = urgent, 2 = important, 3 = normal
        public string Type { get; set; } = "Event";   // "Event" or "Announcement"

        public override string ToString()
        {
            string tag = Type == "Announcement" ? "[Announcement] " : "";
            return $"{Date:dd MMM}  |  {tag}{Name}  |  {Category}  |  {Location}";
        }

        public string ToShortString()
        {
            return $"{Name} ({Date:dd MMM})";
        }
    }

    public static class EventSeeder
    {
        public static List<Event> GetSampleEvents()
        {
            DateTime t = DateTime.Today;
            return new List<Event>
            {
                new Event { Id = 1, Type = "Announcement", Name = "Water maintenance notice", Category = "Utilities", Date = t.AddDays(2), Location = "Ward 12", Priority = 1, Description = "Water will be off from 08:00 to 14:00. Please store water in advance." },
                new Event { Id = 2, Name = "Park clean-up day", Category = "Community", Date = t.AddDays(4), Location = "Civic Park", Priority = 3, Description = "Volunteers needed. Gloves and refreshments provided." },
                new Event { Id = 3, Name = "Load shedding briefing", Category = "Utilities", Date = t.AddDays(6), Location = "Municipal offices", Priority = 2, Description = "Learn how the updated load shedding schedule affects your area." },
                new Event { Id = 4, Name = "Ward committee meeting", Category = "Community", Date = t.AddDays(8), Location = "Town hall", Priority = 3, Description = "Quarterly update on road repairs and service delivery." },
                new Event { Id = 5, Name = "Free health screening", Category = "Health", Date = t.AddDays(10), Location = "Community clinic", Priority = 2, Description = "Blood pressure, glucose and BMI checks for all residents." },
                new Event { Id = 6, Name = "Youth soccer tournament", Category = "Sports", Date = t.AddDays(11), Location = "Municipal stadium", Priority = 3, Description = "Under-15 teams from across the municipality compete." },
                new Event { Id = 7, Name = "Local artists exhibition", Category = "Culture", Date = t.AddDays(14), Location = "Library hall", Priority = 3, Description = "Paintings, pottery and crafts by local artists." },
                new Event { Id = 8, Type = "Announcement", Name = "Main Road resurfacing closure", Category = "Utilities", Date = t.AddDays(16), Location = "Main Road", Priority = 1, Description = "Road closed between 06:00 and 18:00. Use the alternative routes." },
                new Event { Id = 9, Name = "Vaccination drive", Category = "Health", Date = t.AddDays(19), Location = "Community clinic", Priority = 2, Description = "Free childhood and flu vaccinations." },
                new Event { Id = 10, Name = "Neighbourhood watch meeting", Category = "Community", Date = t.AddDays(22), Location = "Community hall", Priority = 3, Description = "Discuss safety patrols and reporting procedures." },
                new Event { Id = 11, Name = "5km fun run", Category = "Sports", Date = t.AddDays(24), Location = "Lakeside Park", Priority = 3, Description = "Open to all ages. Register at the gate from 06:30." },
                new Event { Id = 12, Name = "Farmers market", Category = "Community", Date = t.AddDays(26), Location = "Main square", Priority = 3, Description = "Fresh produce, baked goods and local crafts." },
                new Event { Id = 13, Name = "Community choir concert", Category = "Culture", Date = t.AddDays(29), Location = "Civic theatre", Priority = 3, Description = "An evening of gospel and traditional music." },
                new Event { Id = 14, Type = "Announcement", Name = "Refuse collection changes", Category = "Utilities", Date = t.AddDays(31), Location = "All wards", Priority = 2, Description = "New collection days start this week. Check your ward schedule." },
                new Event { Id = 15, Name = "Blood donation clinic", Category = "Health", Date = t.AddDays(35), Location = "Town hall", Priority = 3, Description = "Every donation can save up to three lives." },
                new Event { Id = 16, Name = "Tariff information session", Category = "Utilities", Date = t.AddDays(38), Location = "Library", Priority = 3, Description = "Explains the new water and electricity tariffs." },
                new Event { Id = 17, Name = "Netball league finals", Category = "Sports", Date = t.AddDays(42), Location = "Sports complex", Priority = 3, Description = "Come and support your local teams." },
                new Event { Id = 18, Name = "Children's storytelling evening", Category = "Culture", Date = t.AddDays(46), Location = "Library", Priority = 3, Description = "Stories, songs and games for children aged 4 to 10." },
                new Event { Id = 19, Name = "Fire safety workshop", Category = "Community", Date = t.AddDays(50), Location = "Fire station", Priority = 2, Description = "Learn basic fire prevention and what to do in an emergency." },
                new Event { Id = 20, Name = "Year-end community festival", Category = "Culture", Date = t.AddDays(58), Location = "Main square", Priority = 3, Description = "Food stalls, live music and entertainment for the whole family." }
            };
        }
    }
}