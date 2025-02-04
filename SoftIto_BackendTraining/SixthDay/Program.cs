using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(comparison(4, 6, "h"));

            int numberx = Convert.ToInt32(Console.ReadLine());
            if (PrimeNumbers(numberx)) { Console.WriteLine("it is prime"); }
            else { Console.WriteLine("it is not a prime number!!"); }

        }

        public static string comparison (int a, int b , string c)
        {
            c= (a>=b) ? ($"{a}is bigger than {b}"):($"{b}is bigger than {a}") ;
            return c;
        }

        public static bool PrimeNumbers(int a)
        {
            bool isPrime = true;
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    i = a;
                }
            }
            return isPrime;
        }



    }
}
