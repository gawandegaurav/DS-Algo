namespace Queue
{
    internal interface IQueue<T>
    {
        T Dequeue();

        void Enqueue(T item);

        bool Contains(T item);

        T Peek();

        void Clear();

        bool IsFull();

        bool IsEmpty();
    }
}