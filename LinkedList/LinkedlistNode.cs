using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedlistNode<T>
    {
        private T data;
        public LinkedlistNode<T> nextNode;

        public LinkedlistNode(T data)
        {
            this.data = data;
            nextNode = null;
        }
    }
}
