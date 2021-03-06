﻿using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        // first node of linkedList
        private LinkedListNode<T> _head;

        public SinglyLinkedList()
        {
            _head = null;
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                newNode.NextNode = _head;
                _head = newNode;
            }
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new LinkedListNode<T>(data);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var node = _head;
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }

                node.NextNode = newNode;
            }
        }

        public void InsertAfterPosition(int position, T data)
        {
            if (_head == null)
            {
                _head = new LinkedListNode<T>(data);
                return;
            }

            if (position < 0)
            {
                InsertAtBeginning(data);
            }
            else
            {
                int i = 1;
                var node = _head;

                while (i < position)
                {
                    i++;
                    node = node.NextNode;
                }
                var newNode = new LinkedListNode<T>(data)
                {
                    NextNode = node.NextNode
                };

                node.NextNode = newNode;
            }
        }

        public LinkedListNode<T> DeleteAtBeginning()
        {
            if (_head == null) { return null; }

            var node = _head;
            _head = node.NextNode;

            node.NextNode = null;
            return node;
        }

        public LinkedListNode<T> DeleteFromEnd()
        {
            if (_head == null) return null;
            var node = _head;
            var previousNode = node;

            while (node.NextNode != null)
            {
                previousNode = node;
                node = node.NextNode;
            }

            previousNode.NextNode = null;
            node.NextNode = null;
            return node;
        }

        public void DeleteAll()
        {
            _head = null;
        }

        public LinkedListNode<T> DeleteFromPosition(int position)
        {
            if (_head == null) return null;

            if (position < 0) position = 0;
            if (position == 0)
            {
                _head = _head.NextNode;
                return _head;
            }

            var count = 1;
            var node = _head;
            var previousNode = node;

            while (count < position)
            {
                previousNode = node;
                node = node.NextNode;
                count++;
            }

            previousNode.NextNode = node.NextNode;
            node.NextNode = null;
            return node;
        }

        public bool Contains(T data)
        {
            var node = _head;
            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    return true;
                }
                node = node.NextNode;
            }

            return false;
        }

        public override string ToString()
        {
            if (_head == null) return string.Empty;
            StringBuilder linkedListString = new StringBuilder();
            foreach (T item in this)
            {
                if (linkedListString.Length > 0)
                    linkedListString.Append("->");
                linkedListString.Append(item);
            }

            return linkedListString.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = _head;
            while (node != null)
            {
                yield return node.Data;
                node = node.NextNode;
            }
        }
    }
}