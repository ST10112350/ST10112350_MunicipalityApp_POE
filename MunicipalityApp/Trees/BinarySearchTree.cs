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
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

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

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        // Find an element by ID
        public T Find(int id)
        {
            return FindRec(root, id);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

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

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        // In-order traversal of the BST
        public IEnumerable<T> InOrderTraversal()
        {
            List<T> result = new List<T>();
            InOrderRec(root, result);
            return result;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void InOrderRec(Node root, List<T> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root.Data);
                InOrderRec(root.Right, result);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        internal void Delete(ServiceRequest requestToRemove)
        {
            if (requestToRemove == null) return;

            // Find the node to remove
            var nodeToRemove = FindNode(root, requestToRemove);
            if (nodeToRemove == null) return;

            // Remove the node
            root = DeleteRec(root, requestToRemove);
        }

        private Node FindNode(Node root, ServiceRequest request)
        {
            if (root == null) return null;

            if ((root.Data as ServiceRequest).Id == request.Id)
                return root;
            else if (request.Id < (root.Data as ServiceRequest).Id)
                return FindNode(root.Left, request);
            else
                return FindNode(root.Right, request);
        }

        private Node DeleteRec(Node root, ServiceRequest request)
        {
            if (root == null) return root;

            if (request.Id < (root.Data as ServiceRequest).Id)
                root.Left = DeleteRec(root.Left, request);
            else if (request.Id > (root.Data as ServiceRequest).Id)
                root.Right = DeleteRec(root.Right, request);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                Node temp = MinValueNode(root.Right);
                root.Data = temp.Data;
                root.Right = DeleteRec(root.Right, temp.Data as ServiceRequest);
            }

            return root;
        }

        private Node MinValueNode(Node node)
        {
            Node current = node;
            while (current.Left != null)
                current = current.Left;
            return current;
        }
    }
}
        //------------------------------------------------------------------------------------------------------[END]----------------------------------------------------------------------------------------------------------//         