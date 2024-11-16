using MunicipalityApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MunicipalityApp.Classes; // Ensure you have this import

namespace MunicipalityApp.Trees
{

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // Node of a binary search tree
        public class Node
        {
            public T Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Insert a new element into the BST
        public void Insert(T data)
        {
            root = InsertRec(root, data);
        }

        private Node InsertRec(Node root, T data)
        {
            if (root == null)
            {
                root = new Node(data);
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

        private T FindRec(Node root, int id)
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

        private void InOrderRec(Node root, List<T> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.Data);
                InOrderRec(root.Right, result);
            }
        }
    }
}
           