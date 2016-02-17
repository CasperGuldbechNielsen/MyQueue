using System;

namespace MyQueue
{
    public class MyQueueIsFullException : Exception
    {
        public MyQueueIsFullException(string message) : base(message)
        {
            
        }
    }
}