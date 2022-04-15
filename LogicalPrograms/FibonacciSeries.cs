using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        int num1 = 0, num2 = 1, temp;
        public void Fibonacci()
        {
            Console.WriteLine("Enter the Value of Series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibbonacci Siries : ");
            Console.Write(+num1);
            for (int i = 1; i < num; i++)
            {
                temp = num1 + num2;
                Console.Write(" " + temp);
                num1 = num2;
                num2 = temp;
            }
        }
    }
}
