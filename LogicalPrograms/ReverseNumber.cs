using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        int rev = 0, rem;
        public void ReverseNum()
        {
            Console.Write("Enter The Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("\nReverse Number is " + rev);
            if (temp == rev)
                Console.WriteLine("\nGiven Number is Palidrom.");
            else
                Console.WriteLine("\nGiven Number is not Palidrom.");
        }
    }
}
