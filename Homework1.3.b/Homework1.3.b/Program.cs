using System;

namespace Homework1._3.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeVal v1, v2;
            Swap(out v1, out v2);
            Console.WriteLine(v1.x);
            Console.WriteLine(v2.x);
        }

        private static void Swap(out SomeVal v1, out SomeVal v2)
        {
            v1 = new SomeVal();
            v1.x = Convert.ToString(Console.ReadLine());
            v2 = v1;
            v1.x = Convert.ToString(Console.ReadLine());
        }

        struct SomeVal { public String x; }



    }
}
