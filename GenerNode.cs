using System;

namespace Tmp
{
    public class Node<T>
    {
        // fields - artibute
        private T value;
        private Node<T> next;


        // constructors
        public Node(T x)
        {
            value = x;
            next = null;
        }

        public Node(T x, Node<T> next)
        {
            value = x;
            this.next = next
        }


        // main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    } //end of class
} // end of namespace 