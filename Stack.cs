using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackandQueue
{
    class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node newnode = new Node(value);
            if (this.top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = this.top;
            }
            this.top = newnode;
            Console.WriteLine("{0} Pushed to the stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("Stack data : " + temp.data);
                temp = temp.next;
            }
        }
    }
}

