using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class Recursion
    {
        // when problem can be breakdown into similar problems 
        // compromise with time and space , mission critical problem cant use recursion 
        // https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
        // Benefits of iteration > space efficiency and  time efficiency (operations > pushs pops)
        // benefits of recursion > ease of code 
        // practical usage >stack, sorting (quick sort mergue sort) > tree traversals , divide and conqure dynamic programming

        #region Febonacci
        public static void CalculateFebonacci()
        {
            Console.WriteLine("which febonacci number needed..");
            var number = Console.ReadLine();
            Console.WriteLine(Febonacci(int.Parse(number)));
        }

        public static int Febonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Febonacci(n - 1) + Febonacci(n - 2);
            }
        } 
        #endregion

        #region Factorial
        public static void CalculateFactorial()
        {
            Console.WriteLine("Enter the number to calculate factorial");
            var number = Console.ReadLine();
            Console.WriteLine(Facto(int.Parse(number)));
        }

        private static int Facto(int number)
        {
            if (number < 1)
            {
                return 1;
            }

            return number * Facto(number - 1);
        }
        #endregion
    }
}
