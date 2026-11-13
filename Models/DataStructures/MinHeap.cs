using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Community_Watcher.Models;

namespace Community_Watcher.DataStructures
{
    public class MinHeap
    {
        private List<ServiceRequest> elements = new List<ServiceRequest>();

        public int Count => elements.Count;

        public void Insert(ServiceRequest item)
        {
            elements.Add(item);
            HeapifyUp(elements.Count - 1);
        }

        public ServiceRequest? ExtractMin()
        {
            if (elements.Count == 0) return null;

            ServiceRequest minItem = elements[0];
            elements[0] = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);

            if (elements.Count > 0)
            {
                HeapifyDown(0);
            }
            return minItem;
        }

        public List<ServiceRequest> ToSortedList()
        {
            List<ServiceRequest> copy = new List<ServiceRequest>(elements);
            copy.Sort((a, b) => a.PriorityScore.CompareTo(b.PriorityScore));
            return copy;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (elements[index].CompareTo(elements[parentIndex]) >= 0) break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = elements.Count - 1;
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild <= lastIndex && elements[leftChild].CompareTo(elements[smallest]) < 0)
                {
                    smallest = leftChild;
                }

                if (rightChild <= lastIndex && elements[rightChild].CompareTo(elements[smallest]) < 0)
                {
                    smallest = rightChild;
                }

                if (smallest == index) break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int i, int j)
        {
            ServiceRequest temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
