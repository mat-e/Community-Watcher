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
    public class BSTNode
    {
        public ServiceRequest Data { get; set; }
        public BSTNode? Left { get; set; }
        public BSTNode? Right { get; set; }

        public BSTNode(ServiceRequest data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        public BSTNode? Root { get; private set; }

        public void Insert(ServiceRequest request)
        {
            Root = InsertRec(Root, request);
        }

        private BSTNode InsertRec(BSTNode? root, ServiceRequest request)
        {
            if (root == null)
            {
                return new BSTNode(request);
            }

            if (request.Id < root.Data.Id)
            {
                root.Left = InsertRec(root.Left, request);
            }
            else if (request.Id > root.Data.Id)
            {
                root.Right = InsertRec(root.Right, request);
            }

            return root;
        }

        public ServiceRequest? Search(int id)
        {
            return SearchRec(Root, id);
        }

        private ServiceRequest? SearchRec(BSTNode? root, int id)
        {
            if (root == null || root.Data.Id == id)
            {
                return root?.Data;
            }

            if (id < root.Data.Id)
            {
                return SearchRec(root.Left, id);
            }

            return SearchRec(root.Right, id);
        }

        public List<ServiceRequest> InOrderTraversal()
        {
            List<ServiceRequest> list = new List<ServiceRequest>();
            InOrderRec(Root, list);
            return list;
        }

        private void InOrderRec(BSTNode? root, List<ServiceRequest> list)
        {
            if (root != null)
            {
                InOrderRec(root.Left, list);
                list.Add(root.Data);
                InOrderRec(root.Right, list);
            }
        }
    }
}