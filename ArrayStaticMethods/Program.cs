using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "orange", "lemon", "grapes" };
            
            PrintArray(fruit);

            //GET THE ELEMENT INDEX
            int index;
            /*index = Array.IndexOf(fruit, "orange");
            Console.WriteLine($"Index of your element is: {index}");*/

            Console.WriteLine("What fruit are you looking?");
            string userAnswer = Console.ReadLine();
            index = Array.IndexOf(fruit, userAnswer);

            if (index != -1  )
            {
                Console.WriteLine($"your fruit  is {userAnswer}");
            }
            else
            {
                Console.WriteLine($"404 {userAnswer} not found");
            }


            Console.ReadLine();


            /*for(int i=0; i < colors.Length; i++)
            {
                Console.WriteLine("Enter a color: ");
                colors[i] = Console.ReadLine();
            }

            //SORT AN ARRAY
            Array.Sort(colors);
            Console.WriteLine("\n");
            Console.WriteLine("Array sorted");
            PrintArray(colors);
            Console.WriteLine("\n");

            //REVERSE AN ARRAY
            Array.Reverse(colors);
            Console.WriteLine("Array reversed: ");
            PrintArray(colors);

            foreach (string color in colors)
            {
                Console.WriteLine(color);
                
            }*/

        }

        public static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
