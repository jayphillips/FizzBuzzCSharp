using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz\n");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz\n");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz\n");
                } else
                {
                    Console.WriteLine(i);
                }
               
            }
            
        }
       
    }
}
