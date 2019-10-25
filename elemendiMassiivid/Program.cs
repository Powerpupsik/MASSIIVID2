using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elemendiMassiivid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 4, -8, 57, 100 };

            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            foreach(int number in numbers)
            {
                if (number<min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Minimum value is {min}");

            foreach (int number in numbers)
            {
                if (number >= max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Maximum value is {max}");

            Console.ReadLine();

        }
    }
}
