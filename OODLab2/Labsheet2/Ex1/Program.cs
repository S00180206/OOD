using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersQuery();
            NumbersLambda();

        }

        private static void NumbersLabda()
        {
            int[] numbers = { 1, 7, , 2, 9, 13, 16, 25, 2 };

            var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach(int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            Console.ReadLine();
        }
    }
}
