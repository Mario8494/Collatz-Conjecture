using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            void treeGame(double num)
            {
                Console.WriteLine($"Tree for {num}:");
                Console.WriteLine(num);
                int steps = 0;
                while(num != 1)
                {
                    if(num % 2 != 0)
                    {
                        num = 3 * num + 1;
                        steps++;
                        if (num < 0)
                        {
                            Console.WriteLine($"{num} is weird");
                            break;
                        }
                        Console.WriteLine(num);
                        if(num < 0)
                        {
                            Console.WriteLine($"{num} is weird");
                            break;
                        }
                    }
                    else
                    {
                        num = num / 2;
                        steps++;
                        if (num < 0)
                        {
                            Console.WriteLine($"{num} is weird");
                            break;
                        }
                        Console.WriteLine(num);  
                    }
                }
                Console.WriteLine($"Done in {steps} steps");
                for(int i = 1; i <= 3; i++)
                {
                    Console.WriteLine();
                }
            }




            //////////////////////////////////////////////////////////////////////////// MAIN ////////////////////////////////////////////////////////////////////////////
            

            

            time.Start();

            double a = Math.Pow(2, 60);
            double b = Math.Pow(2, 64);

            for(double i = a; i < b; i++)
            {
                treeGame(i);
            }

            time.Stop();
            Console.WriteLine($"Done in {time.Elapsed}");
            Console.ReadLine();
        }
    }
}
