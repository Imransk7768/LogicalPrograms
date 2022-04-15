using System;
using LogicalPrograms;

namespace LogicalPograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>> Welcome to Logical Programs <<<<<<<");
            bool end = true;
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Number\n3. Prime Number\n4. End Of The Program");
            while (end == true)
            {
                Console.WriteLine("\nEnter an Option to Exicute.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfect =new PerfectNumber();
                        perfect.perfect_Num();
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.PrimeNum();
                        break;
                    case 4:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter the Valid Option");
                        break;
                }
            }
        }
    }
}