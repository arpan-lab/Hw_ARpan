using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Value1 = 14;
            int Value2 = 7;

            bool isDone = false;

            for (int i = 1; i <= 3; i++)
            {
                Console.Clear(); 
                Console.WriteLine($"Attempt"+i+" of 3");
                Console.Write("Enter first value: ");
                int x= Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second value: ");
                int y= Convert.ToInt32(Console.ReadLine());
                if (x== Value1 && y== Value2)
                {
                    Console.WriteLine("Done");
                    isDone = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Values do not match. Try again.");
                }
                System.Threading.Thread.Sleep(2000); 
            }

            if (!isDone)
            {
                Console.Clear();
                Console.WriteLine("Not Done");
            }

        }
    }
}
