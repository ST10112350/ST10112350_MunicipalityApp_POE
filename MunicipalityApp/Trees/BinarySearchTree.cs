using MunicipalityApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Trees
{
    // Node of a binary search tree
    public class BinarySearchTree
    {
        // Node of a binary search tree
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        // Binary Search Tree (BST) implementation
        public class BinarySearchTree<T> where T : IComparable<T>
        {
            private Node<T> root;

            public BinarySearchTree()
            {
                root = null;
            }

            // Insert a new element into the BST
            public void Insert(T data)
            {
                root = InsertRec(root, data);
            }

            private Node<T> InsertRec(Node<T> root, T data)
            {
                if (root == null)
                {
                    root = new Node<T>(data);
                    return root;
                }

                if (data.CompareTo(root.Data) < 0)
                    root.Left = InsertRec(root.Left, data);
                else if (data.CompareTo(root.Data) > 0)
                    root.Right = InsertRec(root.Right, data);

                return root;
            }

            // Find an element by ID
            public T Find(int id)
            {
                return FindRec(root, id);
            }

            private T FindRec(Node<T> root, int id)
            {
                if (root == null)
                    return default;

                if ((root.Data as ServiceRequest).Id == id)
                    return root.Data;
                else if (id < (root.Data as ServiceRequest).Id)
                    return FindRec(root.Left, id);
                else
                    return FindRec(root.Right, id);
            }

            // In-order traversal of the BST
            public IEnumerable<T> InOrderTraversal()
            {
                List<T> result = new List<T>();
                InOrderRec(root, result);
                return result;
            }

            private void InOrderRec(Node<T> root, List<T> result)
            {
                if (root != null)
                {
                    InOrderRec(root.Left, result);
                    result.Add(root.Data);
                    InOrderRec(root.Right, result);
                }
            }
        }

        // Manager class that uses the BST
        public class ServiceRequestManager
        {
            private BinarySearchTree<ServiceRequest> serviceRequests;

            public ServiceRequestManager()
            {
                serviceRequests = new BinarySearchTree<ServiceRequest>();
            }

            // Add a new service request
            public void AddServiceRequest(ServiceRequest request)
            {
                serviceRequests.Insert(request);
            }

            // Get a service request by ID
            public ServiceRequest GetServiceRequest(int id)
            {
                return serviceRequests.Find(id);
            }

            // Get all service requests (in-order traversal)
            public IEnumerable<ServiceRequest> GetAllServiceRequests()
            {
                return serviceRequests.InOrderTraversal();
            }
        }

    }
}
