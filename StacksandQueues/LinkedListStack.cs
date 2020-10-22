using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    public class LinkedListStack
    {
        internal Node head;
        /// <summary>
        /// Push new element in stack
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            Console.WriteLine("Pushing {0} into Stack", data);
            Node node = new Node(data);

            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node top = this.head;   //head in LinkedList == Top in stack
                node.next = top;
                this.head = node;
            }

        }
        /// <summary>
        /// Peek the element from the stack
        /// </summary>
        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Element peeked is {0}", this.head.data);
        }

        /// <summary>
        /// Pop the element from the stack
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Node temp = this.head;
            int pop = temp.data;
            this.head = temp.next;
            Console.WriteLine("Popped element is {0}", pop);
        }
        /// <summary>
        /// Displays the stack elements
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("Displaying Elements of Stack:");

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Determines whether the stack is Empty
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.head == null)
            {
                return true;
            }
            return false;
        }
    }
}
