using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Community_Watcher.DataStructures
{
    public class Edge
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Weight { get; set; }

        public Edge(string source, string destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }

    public class MunicipalGraph
    {
        public List<string> Vertices { get; private set; } = new List<string>();
        public List<Edge> Edges { get; private set; } = new List<Edge>();

        public void AddVertex(string name)
        {
            if (!Vertices.Contains(name))
            {
                Vertices.Add(name);
            }
        }

        public void AddEdge(string source, string destination, int weight)
        {
            AddVertex(source);
            AddVertex(destination);
            Edges.Add(new Edge(source, destination, weight));
            Edges.Add(new Edge(destination, source, weight));
        }

        public List<Edge> GetMinimumSpanningTree()
        {
            List<Edge> mstEdges = new List<Edge>();
            if (Vertices.Count == 0) return mstEdges;

            HashSet<string> visited = new HashSet<string>();
            visited.Add(Vertices[0]);

            while (visited.Count < Vertices.Count)
            {
                Edge? minEdge = null;
                int minWeight = int.MaxValue;

                foreach (Edge edge in Edges)
                {
                    if (visited.Contains(edge.Source) && !visited.Contains(edge.Destination))
                    {
                        if (edge.Weight < minWeight)
                        {
                            minWeight = edge.Weight;
                            minEdge = edge;
                        }
                    }
                }

                if (minEdge != null)
                {
                    visited.Add(minEdge.Destination);
                    mstEdges.Add(minEdge);
                }
                else
                {
                    break;
                }
            }

            return mstEdges;
        }
    }
}

