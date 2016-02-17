using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> myIntQueue = new MyQueue<int>(5);

            try
            {
                myIntQueue.Enqueue(1);
                myIntQueue.Enqueue(2);
                myIntQueue.Enqueue(3);
                myIntQueue.Enqueue(4);
                myIntQueue.Enqueue(5);
            }
            catch (MyQueueIsFullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
