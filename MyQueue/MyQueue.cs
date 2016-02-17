using System;

namespace MyQueue
{
    class MyQueue<T>
    {
        private const int DEFAULTQUEUESIZE = 100;
        private T[] data;
        private int head = 0, tail = 0;
        private int numElements = 0;

        public MyQueue()
        {
            this.data = new T[DEFAULTQUEUESIZE];
        }

        public MyQueue(int size)
        {
            if (size > 0)
            {
                this.data = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Size", "Must be greater than zero");
            }
        }

        public void Enqueue(T item)
        {
            if (this.numElements == this.data.Length)
            {
                //throw new Exception("Queue full");
                throw new MyQueueIsFullException("Queue is full");
            }
            this.data[this.head] = item;
            this.head++;
            this.head %= this.data.Length;
            this.numElements++;
        }

        public T Dequeue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("Queue empty");
            }

            var queueItem = this.data[this.tail];
            this.tail++;
            this.tail %= this.data.Length;
            this.numElements--;
            return queueItem;
        }
    }
}