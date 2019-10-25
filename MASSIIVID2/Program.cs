using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASSIIVID2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEIA KÕIKIDE MASSIIVIDE SUMMA
            //LEIA MASSIIVIDE SUMMA KESKMINE
            int[] numbers = new int[100];
            int sum = 0;
            int average = 0;
            

            for(int i=0; i< numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            foreach(int num in numbers)
            {
                sum = sum + num;
            }

            

            Console.WriteLine(sum);

            double avarage = sum / numbers.Length;
            Console.WriteLine(avarage);            

           






            Console.ReadLine();
        }
    }
}
