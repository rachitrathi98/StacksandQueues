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
    }
}
