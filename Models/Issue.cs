using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community_Watcher.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public DateTime DateReported { get; set; }

        public Issue(int id, string category, string location, string description, string attachmentPath)
        {
            Id = id;
            Category = category;
            Location = location;
            Description = description;
            AttachmentPath = attachmentPath;
            DateReported = DateTime.Now;
        }
    }
}
