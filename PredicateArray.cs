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
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == input)
                    {
                        Console.WriteLine("Number is within array.");
                        return true;
                    }                         
                }
                Console.WriteLine("Number is out of array.");
                return false;
            };
            Console.WriteLine(predicateArr(array));
        }
    }
}
