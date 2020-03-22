using System;

namespace Queue.Exceptions
{
    public class QueueUnderflowException : Exception
    {
        public QueueUnderflowException(string message) : base(message)
        {

        }
    }
}