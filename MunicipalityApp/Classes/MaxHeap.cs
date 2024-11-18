using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp.Classes
{

    public class MaxHeap
    {
        private List<ServiceRequest> heap;

        public MaxHeap()
        {
            heap = new List<ServiceRequest>();
        }

        public void Insert(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        public ServiceRequest ExtractMax()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            var max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return max;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                var parent = (index - 1) / 2;
                if (heap[index].Priority <= heap[parent].Priority)
                    break;

                Swap(index, parent);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            var lastIndex = heap.Count - 1;
            while (index < lastIndex)
            {
                var left = 2 * index + 1;
                var right = 2 * index + 2;

                if (left > lastIndex)
                    break;

                var largest = (right <= lastIndex && heap[right].Priority > heap[left].Priority) ? right : left;

                if (heap[index].Priority >= heap[largest].Priority)
                    break;

                Swap(index, largest);
                index = largest;
            }
        }

        private void Swap(int index1, int index2)
        {
            var temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
}