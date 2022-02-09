using System;
using System.Linq;

namespace Homework1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTest = Enumerable.Range(1, 100).ToArray();
            for (int i = 0; i < arrayTest.Length; i++)
            {
                if (i % 3 == 0)
                {
                    if ((i % 3 == 0) && (i % 5 == 0)) System.Console.WriteLine("{0} BuzzFizz", i);
                    else System.Console.WriteLine("{0} Fizz", i);
                }
                else if (i % 5 == 0) Console.WriteLine("{0} Buzz", i);
            }
            Console.ReadLine();

        }
    }
}
