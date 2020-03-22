using System;

namespace Queue.Exceptions
{
    public class QueueOverflowException : Exception
    {
        public QueueOverflowException(string message) :base(message)
        {
                
        }
    }
}