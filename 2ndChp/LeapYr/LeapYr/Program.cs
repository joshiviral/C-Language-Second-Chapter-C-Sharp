using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYr
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Year:");
            a = Convert.ToInt16(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine(a + "Is a Leap Year...");
            }
            else
            {
                Console.WriteLine(a + "Is not a Leap Year...");
            }
        }
    }
}
