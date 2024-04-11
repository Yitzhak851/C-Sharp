using System;

namespace Tmp
{
    class CreateSimpleNodeList
    {
        static void Main(string[] args)
        {
            IntNode n1 = new IntNode(10);
            IntNode n2 = new IntNode(20);

            n1.SetNext(n2);
            Console.WriteLine(n1);

            n2.SetNext(new IntNode(17));
            Console.WriteLine(n1);

            n2.SetValue(22);
            Console.WriteLine(n1);

            n1.GetNext().GetNext().SetValue(13);
            Console.WriteLine(n1);


            IntNode first = new IntNode(1);
            IntNode last = first;

            for (int i = 0; i < 3; i++)
            {
                IntNode n = new IntNode(last.GetValue() * 2);
                last.SetNext(n);
                last = n;
            }
            Console.WriteLine(first);
        }
    }
}