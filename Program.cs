using System.Collections;

namespace StackandQueue
{
   class Program
    {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Stack and Queue using Linked List");


            
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Pop();
            stack.Pop();
            stack.Peek();

            Console.ReadLine();
        }
        }
    }

