using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        int count = 0;
        public void PrimeNum()
        {
            Console.Write("Enter a number for prime factors check : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            if (count <= 2)
                Console.WriteLine("\n"+num + " : Is a prime number.");
            else
                Console.WriteLine("\n"+num + " : Is a not prime number.");
        }
    }
}
