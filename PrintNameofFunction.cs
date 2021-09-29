using System;
//Write a class which has a function which can take any function as an argument. Execute the function passed as an argument and Print the nameof the function to be executed.
namespace PrintNameofFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionNameAdd();
        }
        
        public static void FunctionNameAdd()
        {
            Console.WriteLine("Enter input:");
            int a = Int32.Parse(Console.ReadLine());
            Func<int, int> funcAdd = (a) =>
            {
                return a+a;
            };
            Console.WriteLine("Function: Addition of two " + a + " is: " + funcAdd(a));
        }
    }
}
