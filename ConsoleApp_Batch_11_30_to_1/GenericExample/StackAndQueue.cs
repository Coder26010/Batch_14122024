using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.GenericExample
{
    internal class StackAndQueue
    {
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();

            // stack.Push(5);
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // stack.Push(4);
            // stack.Push(5);

            // stack.Pop();
            // stack.Pop();
            // foreach (var item in stack)
            // {
            //     Console.WriteLine(item);
            // }


            Queue<int> queue = new Queue<int>();
            Queue<int> skippedQueue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            skippedQueue.Enqueue(queue.Dequeue());
            //Console.WriteLine("Next Standing Token : " + queue.Peek());

            Console.WriteLine("Token Numbers : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Skipped Token Numbers : ");
            foreach (var item in skippedQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
