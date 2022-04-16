using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CoupanNumbers
    {
        public void cNumbers()
        {
            int count = 0;
            int[] coupon = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16, 17, 18, 19, 20 };
            int length = coupon.Length;
            for (int i = 0; i < length; i++)
            {
                count = 0;
                for (int j = 0; j < i; j++)
                {
                    Random random = new Random();
                    int check = random.Next(1, 20);
                    if (check == coupon[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(coupon[i] + " ");
                }
            }
        }
    }
}
