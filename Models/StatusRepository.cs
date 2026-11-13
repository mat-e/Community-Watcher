using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community_Watcher.DataStructures;

namespace Community_Watcher.Models
{
    public static class StatusRepository
    {
        public static BinarySearchTree ServiceTree { get; private set; } = new BinarySearchTree();
        public static MinHeap PriorityHeap { get; private set; } = new MinHeap();
        public static MunicipalGraph ServiceGraph { get; private set; } = new MunicipalGraph();

        static StatusRepository()
        {
            SeedServiceData();
            SeedGraphData();
        }

        private static void SeedServiceData()
        {
            AddRequest(101, "Water & Sanitation", "Pretoria Central", "Burst water pipe on Paul Kruger St", DateTime.Now.AddDays(-2), RequestStatus.InProgress, 1, "Depot Alpha");
            AddRequest(102, "Electricity", "Mamelodi East", "Substation transformer trip", DateTime.Now.AddDays(-3), RequestStatus.AssignedToEngineer, 1, "Depot Beta");
            AddRequest(103, "Roads & Potholes", "Centurion", "Deep pothole on Old Pretoria Rd", DateTime.Now.AddDays(-5), RequestStatus.Completed, 3, "Depot Gamma");
            AddRequest(104, "Waste Management", "Soshanguve", "Uncollected domestic refuse", DateTime.Now.AddDays(-1), RequestStatus.PendingApproval, 2, "Depot Delta");
            AddRequest(105, "Public Safety", "Hatfield", "Broken streetlights near station", DateTime.Now.AddDays(-4), RequestStatus.InProgress, 2, "Depot Alpha");
        }

        private static void SeedGraphData()
        {
            ServiceGraph.AddEdge("Depot Alpha", "Depot Beta", 12);
            ServiceGraph.AddEdge("Depot Alpha", "Depot Gamma", 18);
            ServiceGraph.AddEdge("Depot Beta", "Depot Delta", 15);
            ServiceGraph.AddEdge("Depot Gamma", "Depot Delta", 10);
            ServiceGraph.AddEdge("Depot Beta", "Depot Gamma", 8);
        }

        public static void AddRequest(int id, string category, string location, string description, DateTime date, RequestStatus status, int priority, string depot)
        {
            ServiceRequest req = new ServiceRequest(id, category, location, description, date, status, priority, depot);
            ServiceTree.Insert(req);
            PriorityHeap.Insert(req);
        }
    }
}
