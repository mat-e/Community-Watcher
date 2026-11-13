using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Community_Watcher.Models
{
    public enum RequestStatus
    {
        AssignedToEngineer = 1,
        InProgress = 2,
        PendingApproval = 3,
        Completed = 4
    }

    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
        public RequestStatus Status { get; set; }
        public int PriorityScore { get; set; }
        public string AssignedDepot { get; set; }

        public ServiceRequest(int id, string category, string location, string description, DateTime dateReported, RequestStatus status, int priorityScore, string assignedDepot)
        {
            Id = id;
            Category = category;
            Location = location;
            Description = description;
            DateReported = dateReported;
            Status = status;
            PriorityScore = priorityScore;
            AssignedDepot = assignedDepot;
        }

        // Formatted display properties for DataGridView binding
        public string StatusDisplay => Status switch
        {
            RequestStatus.AssignedToEngineer => "Assigned to Engineer",
            RequestStatus.InProgress => "In Progress",
            RequestStatus.PendingApproval => "Pending Approval",
            RequestStatus.Completed => "Completed",
            _ => Status.ToString()
        };

        public string PriorityLabel => PriorityScore switch
        {
            1 => "1 - Critical",
            2 => "2 - High",
            3 => "3 - Medium",
            _ => "4 - Low"
        };

        public string DateFormatted => DateReported.ToString("yyyy-MM-dd");

        public int CompareTo(ServiceRequest? other)
        {
            if (other == null) return 1;
            return this.PriorityScore.CompareTo(other.PriorityScore);
        }
    }
}

