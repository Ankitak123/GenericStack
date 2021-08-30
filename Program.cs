using System;
using System.Collections.Generic;
namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mystack = new Stack<string>();
            //Adding Item in stack
            mystack.Push("Mercury");
            mystack.Push("Venus");
            mystack.Push("Earth");
            mystack.Push("Mars");
            mystack.Push("Jupitor");
            mystack.Push("Neptune");
            mystack.Push("Saturn"); 
            mystack.Push("Uranus");
            print(mystack);

            //Accessing Top Item without removing it.
            Console.WriteLine("\nTop Item is : {0}", mystack.Peek());

            //Removing Item from Stack
            Console.WriteLine("\nRemoved Top Item of Stack : " + mystack.Pop());
            Console.WriteLine("\nNow Stack's Items are : ");
            print(mystack);
        }
        public static void print(Stack<string> sp)
        {
            foreach (string s in sp)
            {
                Console.Write(s.ToString() + " | ");
            }
        }
    }
    
}
