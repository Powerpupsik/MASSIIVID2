using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Võrdlus
{
    class Program
    {
        static void Main(string[] args)
        {
            //JUURVILI V PUUVILI (võid teha bool'iga; IF-idega; funktsioonidega)
            string[] fruit = new string[5] { "apple", "apricot", "orange", "banana", "avocado" };
            string[] veggies = new string[5] { "cucumber", "carrot", "beet", "cabbage", "potato" };

            Console.WriteLine("Enter fruit or veggie: ");
            string userAnswer = Console.ReadLine();

            int IndexFruit = Array.IndexOf(fruit, userAnswer);
            int IndexVeggie = Array.IndexOf(veggies, userAnswer);

            if(IndexFruit != -1)
            {
                Console.WriteLine($"It is a fruit");
            }
            else if(IndexVeggie != -1)
            {
                Console.WriteLine($"It's a veggie!");

            }
            else
            {
                Console.WriteLine($"{userAnswer} is something else");
            }

            Console.ReadLine();


            
            

        }

        
    }
}
