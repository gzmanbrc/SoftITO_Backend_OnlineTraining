using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay //31.01.2025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region divide by 3
            /*
            int[] numbers = { 4, 85, 96, 125, 635, 488, 522, 7456, 2365, 10000 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0) { Console.WriteLine(numbers[i]); }
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            foreach (int i in sayilar)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            #endregion

            #region string array 
            /*
            string[] list;
            Console.WriteLine("");
            int value = Convert.ToInt32(Console.ReadLine());
            list = new string[value];
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("");
                list[i] = Console.ReadLine();
            }
            Console.WriteLine("**********");
            int k = 1;
            foreach (var x in list)
            {
                Console.WriteLine(k+"  "+x);
                k++;
            }
            */
            #endregion

            #region minimum value in the array
            /*
            int[] myArray = { 47, 85, 41, 25, 635, 789, 86, 100, 1 };

            int minValue = myArray[0];


            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }

            }
            Console.WriteLine("En küçük Değer:" + minValue);
            */
            #endregion

            #region sum of elements in array
            /*
            int[] numbers = { 2, 5, 10, 14, 15, 66, 152, 778, 77, 789, 652 }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum+= numbers[i];
            }
            Console.WriteLine(sum);
            */
            #endregion

            #region sum even and odd 
            /*
            int odd = 0;
            int even = 0;

            int[] myArray = { 47, 85, 41, 25, 3, 789, 86, 100, 8 };
            foreach (var item in myArray)
            {
                if (item % 2 == 0)
                {
                    even += item;
                }
                else
                {
                    odd += item;
                }
            }

            Console.WriteLine(even);
            Console.WriteLine("********");
            Console.WriteLine(odd);
            */
            #endregion

            #region series
            /*
            int[] numbers = { 5, 58, 8, 9, 51 };//5  index 4
                                                // Console.WriteLine(sayilar[5]);
            numbers = new int[6];
            numbers[0] = 58;
            numbers[1] = 55;
            numbers[2] = 53;
            numbers[3] = 51;
            numbers[4] = 35;
            numbers[5] = 25;
            Console.WriteLine(numbers.Length);
            Console.WriteLine("--------------------------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            int[] evenNumbers;
            Console.WriteLine("How many elements will the array have?");
            int elementsnumber = int.Parse(Console.ReadLine());
            evenNumbers = new int[elementsnumber];
            for (int i = 0; i < elementsnumber; i++)
            {
                Console.Write("enter the elements of series ");
                evenNumbers[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            Console.WriteLine("------------------------");
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            // Methods

            //Public or Private 
            //returnType methodName()
            // { method body }


            methods2();
            Program p = new Program();
            p.methods1();
            
        }

        public void methods1() 
        {
            Console.WriteLine("hello!");
        }

        public static void methods2()
        {
            Console.WriteLine("hi!");
        }




    }
}
