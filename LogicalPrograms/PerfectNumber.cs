using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        int n = 0;
        public void perfect_Num()
        {
            Console.WriteLine("Enter a Number to Check : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    n = n + i;
                }
            }
            if (n == temp)
            {
                Console.WriteLine("Number : " + num +" Is a Perfect Number.");
            }
            else
            {
                Console.WriteLine("Number : "+ num +" Is Not a Perfect Number.");
            }
        }
    }
}
