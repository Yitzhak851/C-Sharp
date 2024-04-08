using System;

namespace Tmp
{

    public class Node
    {
        // fields - artibute
        private int value;
        private IntNode next;
        // constructors
        public IntNode(int value)
        {
            this.value = value;
            this.next = null;
        }
        public IntNode(int, IntNode next)
        {
            this.value = value;
            this.next = null;
        }
        public int GetValue()
        {
            return value;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }
        public IntNode GetNext()
        {
            return next;
        }
        public void SetNext(IntNode next)
        {
            rthis.next = next;
        }
        public bool HasNext()
        {
            return this.next != null;
        }
        public override string Tostring()
        {
            return this.value + " --> " + this.next;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    } // end of namespace