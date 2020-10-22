using System;
using System.Collections.Generic;
using System.Text;

namespace StacksandQueues
{
    public class Node
    {
        internal int data;
        internal Node next;
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
