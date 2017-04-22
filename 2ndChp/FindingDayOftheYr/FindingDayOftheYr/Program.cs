using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingDayOftheYr
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            int a, b, d,i,cnt=31,ct=30;
            string[] day = new string[7];
            day[0] = "sd";
            day[1] = "md";
            day[2] = "td";
            day[3] = "wd";
            day[4] = "thd";
            day[5] = "fd";
            day[6] = "std";

            string[] month = new string[12];
            month[0] = "jan";
            month[1] = "feb";
            month[2] = "mar";
            month[3] = "apr";
            month[4] = "may";
            month[5] = "jun";
            month[6] = "jul";
            month[7] = "aug";
            month[8] = "sep";
            month[9] = "oct";
            month[10] = "nov";
            month[11] = "dec";

   
            Console.WriteLine("Enter year between 2000 to 2100:");
            a = Convert.ToInt16(Console.ReadLine());
            for (i = 2000; i <= 2100; i++)
            {
                if (a < 2000 || a > 2100)
                {
                    Console.WriteLine("Its Not a valid Year:\n");
                    Console.WriteLine("Please Try Again..");
                }
                else
                {
                    Console.WriteLine("Enter Month:");
                    b = Convert.ToInt16(Console.ReadLine());
                    for (i = 1; i <= 12; i++)
                    {
                        if (b < 1 || b > 12)
                        {
                            Console.WriteLine("There are only 12 months a year:");
                        }
                        else
                        {
                            if (b == 1 | b == 3 | b == 5 | b == 7 | b == 9 | b == 11)
                            {
                                
                                Console.WriteLine("Its 31 days month..{0}", +cnt);
                                for (i = 1; i <= cnt; i++)
                                {

                                }
                            }
                            else
                            {
                                Console.WriteLine("Its 30 days month..{0}", +ct);
                                for (i = 1; i <= ct; i++)
                                {

                                }
                            }
                            Console.WriteLine("Which day:");
                            c = Convert.ToString(Console.ReadLine());
                            foreach (string s in day)
                            {
                                if (c == s)
                                {
                                    Console.WriteLine("",s);
                                }
                            }
                      }
                    }
                  }
                }
            }
        }
    }