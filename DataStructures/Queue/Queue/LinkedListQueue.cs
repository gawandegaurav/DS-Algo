using System;
using System.Collections;
using System.Text;
using LinkedList;
using Queue.Exceptions;

namespace Queue
{
    public class LinkedListQueue<T> : IQueue<T>, IEnumerable
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> end;
        public int Length => GetLength();

        public LinkedListQueue()
        {
            head = null;
            end = null;
        }

        public void Clear()
        {
            head = null;
            end = null;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("empty queue");
            }

            return head.Data;
        }

        public bool Contains(T item)
        {
            if (head == null) return false;
            var node = head;
            while (node != null)
            {
                if (node.Data.Equals(item))
                {
                    return true;
                }

                node = node.NextNode;
            }

            return false;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new QueueUnderflowException("empty queue.");
            var node = head;
            head = head.NextNode;
            return node.Data;
        }

        public void Enqueue(T item)
        {
            var node = new LinkedListNode<T>(item);

            if (IsEmpty())
            {
                head = node;
                end = node;
                return;
            }

            end.NextNode = node;
            end = node;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public bool IsFull()
        {
            throw new InvalidOperationException();
        }

        public override string ToString()
        {
            if (head == null) return string.Empty;
            StringBuilder returnString = new StringBuilder();
            foreach (T item in this)
            {
                if (returnString.Length > 0)
                    returnString.Append("->");
                returnString.Append(item);
            }

            return returnString.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            var node = head;
            while (node != null)
            {
                yield return node.Data;
                node = node.NextNode;
            }
        }

        private int GetLength()
        {
            if (IsEmpty()) return 0;
            var node = head;
            var count = 0;
            while (node != null)
            {
                node = node.NextNode;
                count++;
            }

            return count;
        }
    }
}