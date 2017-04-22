using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {       
        static void Main(string[] args)
        {
            int a, b, sqn;
            Console.WriteLine("Enter any number:");
            a = Convert.ToInt16(Console.ReadLine());
            
            sqn = a * a;
            Console.WriteLine("The number is:{0}",sqn);
            if ((a * a) == sqn)
            {
                Console.WriteLine(sqn + "{0} is a perfect square:");
            }
            else {
                Console.WriteLine(sqn + "{0} is  not a perfect square:");
            }
        }
    }
}