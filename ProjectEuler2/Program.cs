using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            int b=2;
            List<int> evens = new List<int>();
            //add 2 cause even
            evens.Add(b);

            while (b < 4000000)
            {
                int sum = a + b;
                a = b;
                b = sum;

                if (sum % 2 == 0)
                {
                    evens.Add(sum);
                }
            }

            int total = 0;

            foreach (int x in evens)
            {
                total += x;
            }

            Console.WriteLine(total.ToString());
        }
    }
}
