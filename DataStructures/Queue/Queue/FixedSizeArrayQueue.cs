using Queue.Exceptions;

namespace Queue
{
    public class FixedSizeArrayQueue<T> : IQueue<T>
    {
        private T[] _queueArray;
        private int _front;
        private int _rare;
        public int Size => _queueArray.Length;

        public int Length => GetLength();

        public FixedSizeArrayQueue(int queueSize)
        {
            _queueArray = new T[queueSize];
            _front = -1;
            _rare = -1;
        }

        public bool IsEmpty()
        {
            return _front == _rare;
        }

        public bool IsFull()
        {
            return _rare == Size - 1;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                throw new QueueOverflowException("Queue is full");
            }

            if (_front == -1) _front++;

            _rare++;
            _queueArray[_rare] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("Queue is empty");
            }

            var popedElement = _queueArray[_front];
            _queueArray[_front] = default;
            _front++;

            return popedElement;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("empty queue");
            }

            return _queueArray[_front];
        }

        public void Clear()
        {
            for (int i = 0; i < Length; i++)
            {
                _queueArray[i] = default;
            }
            _front = -1;
            _rare = -1;
        }

        public bool Contains(T item)
        {
            if (IsEmpty()) return false;

            for (int i = 0; i < Length; i++)
            {
                if (_queueArray[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        private int GetLength()
        {
            if (IsEmpty()) return 0;
            return _rare - _front + 1;
        }
    }
}