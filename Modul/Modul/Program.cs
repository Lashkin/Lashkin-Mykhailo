using System;

namespace Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] itemlist = {};
            Console.WriteLine("Enter command");
            String commandTest = Console.ReadLine();
            while (commandTest == "add-item")
            {
                Console.WriteLine("Enter item");
                string firstItem = Console.ReadLine();
                string secondItem = Console.ReadLine();
                string thirdItem = Console.ReadLine();
                addItem(ref itemlist, firstItem, 0);
                return;
            }
            while (commandTest == "remove-item")
            {
                Console.WriteLine("Enter item");
                string firstItem = Console.ReadLine();
                string secondItem = Console.ReadLine();
                string thirdItem = Console.ReadLine();
                remItem(ref itemlist, firstItem);
                return;
            }
        }

        static void addItem(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }

        static void remItem(ref int[] array, int index)
        {
            int[]newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++) 
                newArray[i] = array[i];
            for (int i = index + 1; i < array.Length;i++)
                newArray[i - 1] = array[i];
            array = newArray;
        }
        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
