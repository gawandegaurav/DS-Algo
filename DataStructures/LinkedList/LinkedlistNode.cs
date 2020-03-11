namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode<T> NextNode { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
            NextNode = null;
        }
    }
}