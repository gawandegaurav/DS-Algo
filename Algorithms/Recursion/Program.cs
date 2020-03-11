using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = "";
            Console.WriteLine("Welcome ...");
            //do
            //{
            //    Recursion.CalculateFactorial();
            //    Console.WriteLine("want to try another number..??(Y/N)");
            //    response = Console.ReadLine();
            //} while (response.ToUpper() == "Y");

            do
            {
                Recursion.CalculateFebonacci();

                Console.WriteLine("want to try another number..??(Y/N)");
                response = Console.ReadLine();
            } while (response.ToUpper() == "Y");


        }
    }
}
