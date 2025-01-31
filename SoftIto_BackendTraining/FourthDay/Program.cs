using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FourthDay //30/01/2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                *
               ***
              ******
             ********
              ******
                ***
                 *
            */
            #region baklava
            /*
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = n - 1 - i; j > 0; j--) // bosluk 3 2 1 0 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)// 1 3 5 7 
                {
                    Console.Write("*");
                }
            }
            for (int l = 0; l < n; l++) // 5 3 1
            {
                Console.WriteLine();
                for (int m = 0; m < l + 1; m++) // 1 2 3
                {
                    Console.Write(" ");
                }
                for (int f = n - 2 * l + 1; f > 0; f--)
                {
                    Console.Write("*");
                }


            }
            */
            #endregion


            #region fibonacci
            /*
            int num1 = 0;
            int num2 = 1;
            int total = 0;
            int step = 6;

            Console.Write($"{num2} ");

            for (int i = 0; i < step - 1; i++)
            {
                total = num1 + num2;
                Console.Write($"{total} ");

                num1 = num2;
                num2 = total;
            }
            
            Console.WriteLine("enter a number for fibonacci:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 1, b = 1;
            for (int i = 0; i <= number; i++)
            {
                Console.Write(a);
                sum = a + b;
                a = b;
                b = sum;

            }
            */
            #endregion

            #region prime number 
            /*
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string a = " ";
            for (int i = 2; i <= number; i++)
            {
                bool status = true;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        status = false;
                        break;
                    }
                }
                if (status==true)
                {
                    a = a + i + " ";

                }
            }
            Console.WriteLine(a);
            */
            #endregion

            #region multipliers of 1000
            /*
            for (int a = 1; a <= 500; a++)
            {
                if (1000 % a == 0) { Console.WriteLine(a); }
            }
            */
            #endregion

            // 3 times entry rights
            //withdraw money, send money, check balance, exit
            #region bank
            // 3 kere giriş hakkı
            // para çekme, para gönderme, bakiye kontrol, çıkış,
            int hak = 3;
            int secim = 0;
            int bakiye = 1000;
            int miktar = 0;

            for (hak = 3; hak >= 1;)
            {
                if (hak > 0)
                {
                    Console.WriteLine("1) Para Çekme \n2) Para Gönderme \n3) Bakiye yükleme \n4) Bakiye Kontrol \n5) Çıkış");
                    secim = int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Çekmek istediğiniz miktarı giriniz:");

                        x:
                            miktar = int.Parse(Console.ReadLine());

                            if (bakiye == 0)
                            {
                                Console.WriteLine("Bakiyeniz Yok.");
                                break;
                            }

                            else if (miktar > bakiye)
                            {
                                Console.WriteLine($"Çekmek istediğiniz miktar bakiyenizden fazla. İstediğin: {miktar} Bakiyen: {bakiye}");
                                Console.WriteLine("\nLütfen tekrar miktarı giriniz:");
                                goto x;
                            }
                            else
                            {
                                bakiye -= miktar;
                                Console.WriteLine($"Çektiğiniz miktar: {miktar} Kalan Bakiye: {bakiye}");
                            }

                            break;
                        case 2:
                            Console.WriteLine("Göndermek istediğiniz miktarı giriniz:");
                        y:
                            miktar = int.Parse(Console.ReadLine());

                            if (bakiye == 0)
                            {
                                Console.WriteLine("Bakiyeniz Yok.");
                                break;
                            }

                            else if (miktar > bakiye)
                            {
                                Console.WriteLine($"Göndermek istediğiniz miktar bakiyenizden fazla. İstediğin: {miktar} Bakiyen: {bakiye}");
                                Console.WriteLine("\nLütfen tekrar miktarı giriniz:");
                                goto y;
                            }
                            else
                            {
                                bakiye -= miktar;
                                Console.WriteLine($"Gönderdiğiniz miktar: {miktar} Kalan Bakiye: {bakiye}");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Yüklemek istediğiniz miktarı giriniz:");
                            miktar = int.Parse(Console.ReadLine());

                            bakiye += miktar;

                            break;
                        case 4:
                            Console.WriteLine($"Bakiyeniz = {bakiye}");
                            break;
                        case 5:
                            hak = 0;
                            Console.WriteLine("Güle Güle");
                            break;
                        default:
                            Console.WriteLine("Lütfen doğru seçenekleri seçiniz!..");
                            break;
                    }

                }
                else
                {
                    hak--;
                    Console.WriteLine("Kartınız Bloke Edildi.");
                    break;
                }

            }
           #endregion


                // compare for with while
                /*
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("hi!");
                }
                int x = 0;
                while( x<=10)
                {
                    Console.WriteLine(x);
                    x++;
                }
                */

                //print even numbers up to the number entered by the user
                #region first while example
                /*
                Console.WriteLine("Please enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                int a = 0;
                while (a < number)
                {
                    if (a % 2 == 0) {Console.WriteLine(a); }
                    a++;
                }

                */
                #endregion


                #region back from 1000
                /*
                int number = 1000;
                while (number > 0) 
                {
                    Console.WriteLine(number);
                    number-=3;
                }
                */
                #endregion

                //When the user enters 4 and a multiple of 4, the loop is terminated.
                #region 4k
                /*
                int sum = 0;
                Console.WriteLine("Please enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                while (number%4 !=0)
                {
                    sum =sum +number;
                    Console.WriteLine("Please enter a number");
                    number = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(sum);
                */
                #endregion

                //Multiplication of numbers until the user enters zero
                #region multiplication
                /*
                int multi = 1;
                Console.WriteLine("Please enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                while (number != 0) 
                {
                    multi *= number;
                    Console.WriteLine("Please enter a number");
                     number = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(multi);
                */
                #endregion

                //10 x 10
                #region ...
                /*
                int i = 1;
                while (i<=10)
                {
                    int k = 1;
                    while (k<=10)
                    {
                        Console.WriteLine($"{i} x {k} = {i*k}");
                        k++;
                    }
                    Console.WriteLine("---------");
                    i++;

                }
                */
                #endregion

                // print 1 to 10 except 8
                #region printing
                /*
                int i = 0;
                while (i <10)
                {
                    i++;
                    if (i == 8) { continue; }
                    Console.WriteLine(i);
                }
                */
                #endregion



                //SERIES
                #region series
                //int[] numbers = { 0, 2, 3, 4, 5 };
                #endregion

                #region course list series
                /*
                string[] courselist;
                Console.WriteLine("how many people in your class?");
                int sizeofCourse = int.Parse(Console.ReadLine());
                courselist = new string[sizeofCourse];
                for (int i = 0; i < courselist.Length; i++)
                {
                    Console.WriteLine($"{i+1}.person");
                    string person = Console.ReadLine();
                    courselist[i] = person;
                }
                Console.Clear();
                Console.WriteLine("---------");
                foreach (var item in courselist)
                {
                    Console.WriteLine(item);

                }
                */
                #endregion

            
        }
    }
}
