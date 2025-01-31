using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // String Interpolation: 
            //Console.WriteLine("Hi my name is "+name+"and my age is "+age);
            //Console.WriteLine($"Hi my name is {name} and my age is {age}");   this two writing things give the same outputs. 



            #region we calculate body mass index by using only if else condition
            /*
            Console.WriteLine("Please! Enter your height, write hesight like 100");
            double height = double.Parse(Console.ReadLine());
            height = height / 100;

            Console.WriteLine("Please! Enter your weight");
            double weight = double.Parse(Console.ReadLine());
            double index = 0;
            index = weight / (height * height);

            if (index<18.5) { Console.WriteLine($"your body mass index {index}, You are weak! "); }
            else if (index >= 18.5 && index< 25 ) { Console.WriteLine($"your body mass index {index}, You are healty! "); }
            else if (index >=25 && index< 30) { Console.WriteLine($"your body mass index {index}, You are fat! "); }
            else if (index >=30 && index<39) { Console.WriteLine($"your body mass index {index}, You are obese! "); }
            else { Console.WriteLine($"your body mass index {index}, You are extewmwly obese! "); }

            */
            #endregion

            #region  calculate fuel price and remaining budget
            /*
            double lpgPrice = 23; double gasolinePrice = 20; double dieselPrice = 25;
            double fuelPrice;
        a:
            Console.WriteLine("hello! what do you want to buy as a fuel? gasoline, lpg, diesel");
            string option = Console.ReadLine();
            Console.WriteLine("How many liters of fuel do you want?");
            double liter = double.Parse(Console.ReadLine());
            Console.WriteLine("what is your budget?");
            double budget = double.Parse(Console.ReadLine());
            fuelPrice =0;
            if (option == "gasoline") 
            {
              fuelPrice = liter * gasolinePrice;
              if (budget > fuelPrice) { Console.WriteLine($"you have to pay {fuelPrice}, your new budget is {budget-fuelPrice}"); }
                else { Console.WriteLine("you dont have to enough budget!! you have to more {fuelPrice- budget}"); goto a; }
            }
            else if (option == "lpg")
            {
                fuelPrice = liter * lpgPrice;
                if (budget > fuelPrice) { Console.WriteLine($"you have to pay {fuelPrice}, your new budget is {budget - fuelPrice}"); }
                else { Console.WriteLine("you dont have to enough budget!! you have to more {fuelPrice- budget}"); goto a; }
            }
            else if (option == "diesel")
            {
                fuelPrice = liter * dieselPrice;
                if (budget > fuelPrice) { Console.WriteLine($"you have to pay {fuelPrice}, your new budget is {budget - fuelPrice}"); }
                else { Console.WriteLine("you dont have to enough budget!! you have to more {fuelPrice- budget}"); goto a; }
            }
            else
            {
                Console.WriteLine("you enter the wrong word please try again");
                goto a;
            }
            */
            #endregion


            //Ternary --> its like short if else condition  ****  condition ? if_true_do_this : if_false_do_this;  ****

            #region Switch Case  -- Which season has which months?

            // if we do it only if else condition 
            /*
            b:
            string choice = Console.ReadLine();
            
            choice = choice.ToLower();
            if (choice== "summer" || choice=="y") 
            {
                Console.WriteLine("June July August");
            }
            else if (choice == "spring"|| choice == "s")
            {
                Console.WriteLine("March April May");
            }
            else if (choice == "autumn" || choice == "a")
            {
                Console.WriteLine("september october november");
            }
            else if (choice == "winter" || choice == "w")
            {
                Console.WriteLine("December January February");
            }
            else { Console.WriteLine("you enter the wrong word please try again!!"); goto b; }
            

            // switch case hali
            switch (choice)
            {
                case "summer":
                    Console.WriteLine("June July August");
                    break;
                case "spring":
                    Console.WriteLine("March April May");
                    break;
                case "autumn":
                    Console.WriteLine("september october november");
                    break;
                case "winter":
                    Console.WriteLine("December January February");
                    break;
                default:
                    Console.WriteLine("you enter the wrong word please try again!!");
                    goto b;
            }
            */
            #endregion

            #region calculator
            /*
            double result = 0;
            Console.WriteLine("please enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            s:
            Console.WriteLine("choose the symbol + - * / ");
            char symbol = char.Parse(Console.ReadLine());
            a:
            Console.WriteLine("please enter the second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.Clear();
            z:
            switch (symbol)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(" result is " + result);
                    goto s;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine(" result is " + result);
                    goto s;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine(" result is " + result);
                    goto s;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(" result is " + result);
                    }
                    else { Console.WriteLine("you cant enter 0 as a second number!"); goto a; }
                    goto s;

                default:
                    Console.WriteLine("you enter the wrong symbol try again");
                    char symbol = char.Parse(Console.ReadLine());
                    goto z;
            }
            */
            #endregion

            // loops --> for - do while - while 

            #region for
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hi i am gizem");
            }
            */
            #endregion

            #region Sum of numbers up to the selected number
            /*
            Console.WriteLine("please enter a number ");
            int numbera = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= numbera; i++)
            {
                sum = sum + i;   
            }
            Console.WriteLine(sum);
            */
            #endregion


            #region ***
            /*
             ***
             ***
             ***
             ***
            */
            /*
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
            }
            
            int column, row;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    Console.Write("*");
                }
            }
            */
            #endregion


            /*
                *
                **
                ***
                ****
                *****
            */
            #region  **
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 5-i; j >0; j--)// for blank space
                {
                    Console.Write(" ");

                }
                for (int x = 0; x <i ; x++)
                {
                    Console.Write("*");
                }
            }
            */
            #endregion

            /*
                   *
                  **
                 ***
                ****
               *****
           */
            #region ***
            /*
                   *
                  **
                 ***
                ****
               *****
           */
            /*
            int n = 5; // Satır sayısı

            for (int i = 1; i <= n; i++) // Satırları döner
            {
                for (int j = 1; j <= n - i; j++) // Boşlukları yazdırır  
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++) // Yıldızları yazdırır
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Yeni satıra geç
            }

            */
            #endregion

            /*
             *****
              ****
               ***
                **
                 *

            */

            #region ****
            // n row
            //*****
            //****
            //***
            //**
            //*


            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n-i; j++) //for star            
            //    {
            //        Console.Write("*");
            //    }
            //    for (int k = 1; k < n; k++)//for blankspace
            //    {
            //        Console.Write(" ");
            //    }
            //}

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n - i; j++) //for star            
            //    {
            //        Console.Write("*");
            //    }

            //    for (int k = 0; k < i; k++)//for blankspace
            //    {
            //        Console.Write(" ");
            //    }
            //}

            #endregion




            /*
                *
               ***
              *****
             *******
            *********
               ***
               ***
               ***
              
             */

            #region
            int n = 5;
            for (int i = 0; i < 5; i++) // agacin tepesi
            {
                Console.WriteLine();
                for (int j = 4-i; j >0 ;j--)// 4 3 2 1 0 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <i*2 +1; k++) // 1 3 5 7 9 
                {
                    Console.Write("*");
                }

            }
            for (int l = 0; l < 3; l++) //agacin govdesi
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
            }

            #endregion

        }
    }
}
