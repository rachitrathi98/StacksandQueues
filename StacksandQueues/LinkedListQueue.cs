using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    public class LinkedListQueue
    {
        Node head;
        /// <summary>
        /// Adds element to the Queue
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into queue " + new_node.data);
        }
        /// <summary>
        /// Dequeues the element from the queueu
        /// </summary>
        public void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }
        /// <summary>
        /// Displays the Queue
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Determines whether the Queue is Empty
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
