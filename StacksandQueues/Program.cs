using System;

namespace StacksandQueues
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues using Linked List");
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            while (!stack.IsEmpty())
            {
                stack.Peek();
                stack.Pop();
                stack.Display();
            }
          
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
