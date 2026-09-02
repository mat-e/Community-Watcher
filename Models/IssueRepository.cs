using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Watcher.Models
{
    public static class IssueRepository
    {
        private static readonly List<Issue> _issues = new List<Issue>();
        private static int _nextId = 1;

        public static IReadOnlyList<Issue> Issues
        {
            get { return _issues.AsReadOnly(); }
        }

        public static Issue AddIssue(string category, string location, string description, string attachmentPath)
        {
            var issue = new Issue(_nextId++, category, location, description, attachmentPath);
            _issues.Insert(0, issue);
            return issue;
        }

        public static int Count
        {
            get { return _issues.Count; }
        }
    }
}
