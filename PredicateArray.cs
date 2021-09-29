using System;

namespace PredicateArray
{
    //Create a class which has an array with some values. Constitute a function which can eveluate whether a user provided parameter is present in the array using Predicate delegate.
    class Program
    {
        static void Main(string[] args)
        {
            PredicateArray();         
        }
        public static void PredicateArray()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int input = Int32.Parse(Console.ReadLine());
            Predicate<int[]> predicateArr = (array) =>
            {
                if (input >= 1 && input <= 5)
                {
                    Console.WriteLine("Number is within array.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Number is out of array.");
                    return false;
                }
            };
            Console.WriteLine(predicateArr(array));
        }
    }
}
