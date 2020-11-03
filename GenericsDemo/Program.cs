using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to .Net Generics.");
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'A', 'S', 'D', 'L', 'O'};

            ///Without Generics
            //Program.toPrint(intArray);
            //Program.toPrint(doubleArray);
            //Program.toPrint(charArray);

            //////With Generics
            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }

        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------");
        }

        //public static void toPrint(double[] inputArray)
        //{
        //    foreach (var element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("----------------------------");
        //}

        //public static void toPrint(char[] inputArray)
        //{
        //    foreach (var element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("----------------------------");
        //}
    }
}
