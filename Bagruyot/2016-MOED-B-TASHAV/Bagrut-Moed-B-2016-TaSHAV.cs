using System;

namespace 2016-MOED-B-TASHAV
{
    class Bagrut-Moed-B-2016-TaSHAV
    {
        // Q-1
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i=0; i< arr.Length ; i++)
        {
            if (arr[i] < num )
            sum = sum + arr[i];
        }
        Console.WriteLine( "sum = " + sum);                 

        // Q-2
        class A 
        {
            // Q-2-a-1 ======= תכונות המחלקה  ========
            private int n1;
            private int n1;

            // Q-2-a-2 ======= בנאי המחלקה  ========
            public A (){}
            public A (int n1, int n2){ this.n1 = n1; this.n2 = n2; }

            // Q-2-a-3 ======= Set + Get  יצירת פעולות   ========
            public int GetN1 (){ return this.n1; }
            public int GetN2 (){ return this.n2; }
            public void SetN1 (int n1){ this.n1 = n1;}
            public void SetN2 (int n2){ this.n2 = n2;}
        }
    }
}