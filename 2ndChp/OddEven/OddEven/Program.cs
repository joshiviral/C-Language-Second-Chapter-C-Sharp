using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt16(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + "The Number is Even");
            }
            else
            {
                Console.WriteLine(n + "The Number is odd");
            }

        }
    }
}
