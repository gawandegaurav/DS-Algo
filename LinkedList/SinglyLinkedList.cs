namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        private LinkedlistNode<T> _head;

        public SinglyLinkedList()
        {
            _head = null;
        }

        public void InsertAtBeginning(T data)
        {
            var newNode = new LinkedlistNode<T>(data);
            _head.nextNode = newNode;
        }

        public void InsertAtEnd(T data)
        {
            var newNode = new LinkedlistNode<T>(data);
            if (_head == null)
            {
                _head.nextNode = newNode;
            }
            else
            {
                var node = _head;
                while (node.nextNode != null)
                {
                    node = node.nextNode;
                }

                node.nextNode = newNode;
            }
        }

        public void InsertAfterNode(LinkedlistNode<T> previousNode, T data)
        {
            if (previousNode == null) { return; }

            var nextNode = new LinkedlistNode<T>(data);
            nextNode.nextNode = previousNode.nextNode;
            previousNode.nextNode = nextNode;
        }

        public void InsertAtPosition(int position, T data)
        {
            if (_head == null)
            {
                _head = new LinkedlistNode<T>(data);
                return;
            }
            else if (position < 0)
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
                    node = node.nextNode;
                }
                var newNode = new LinkedlistNode<T>(data);
                newNode.nextNode = node.nextNode;

                node.nextNode = newNode;
            }
        }

        public LinkedlistNode<T> DeleteAtBeginning()
        {
            if (_head == null) { return null; }

            var node = _head;
            _head = node.nextNode;

            node.nextNode = null;
            return node;
        }

        public LinkedlistNode<T> RemoveFromEnd()
        {
            if (_head == null) return null;
            var node = _head;
            var previousNode = node;

            while (node.nextNode != null)
            {
                previousNode = node;
                node = node.nextNode;
            }

            previousNode.nextNode = null;
            node.nextNode = null;
            return node;
        }

        public void DeleteAll()
        {
            _head = null;
        }

        public LinkedlistNode<T> RemoveFromPosition(int position)
        {
            if (_head == null) return null;

            if (position < 0) position = 0;
            if (position == 0)
            {
                _head = _head.nextNode;
                _head.nextNode = null;
                return _head;
            }

            int count = 1;
            var node = _head;
            var previousNode = node;

            while (count < position)
            {
                previousNode = node;
                node = node.nextNode;
                count++;
            }

            previousNode.nextNode = node.nextNode;
            node.nextNode = null;
            return node;
        }
    }
}