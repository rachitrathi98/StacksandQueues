﻿using System;

namespace StacksandQueues
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues using Linked List");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}
