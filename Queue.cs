using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
   
        class Queue
        {
            Node Front;
            Node Rear;
            public Queue()
            {
                this.Front = null;
                this.Rear = null;
            }
            public void Enqueue(int value)
            {
                Node newnode = new Node(value);
                if (this.Rear == null)
                {
                    this.Front = this.Rear;
                    this.Rear = newnode;
                }
                else
                {
                    this.Rear.next = newnode;
                    this.Rear = newnode;
                }
                Console.WriteLine("{0} node added to Queue", value);
            }
            public void Display()
            {
                Node temp = this.Rear;
                if (temp == null)
                {
                    Console.WriteLine("Queue is Empty");
                    return;
                }
                while (temp != null)
                {
                    Console.WriteLine("Queue Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }

