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
            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is Empty");
                }
                Console.WriteLine("Item popped is {0}", top.data);
                top = top.next;
            }
            public void Peek()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty");
                }
                Console.WriteLine("{0} is top os the stack", top.data);
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


