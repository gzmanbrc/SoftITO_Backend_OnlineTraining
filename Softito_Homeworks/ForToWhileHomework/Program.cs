using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForToWhileHomework
{
    internal class Program // 31/01/2025
    {
        static void Main(string[] args)
        {

            // Derste yapilan for dongulerinin while ile yapilmis halleri 

            #region girilen sayiya kadar olan sayilarin cift tek ayri ayri toplami
            /*
            Console.WriteLine("bir sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int tektoplam = 0;
            int cifttoplam = 0;
            while (i<= sayi) 
            {
                if (i % 2 == 0) { cifttoplam += i; }
                else { tektoplam += i; }
                i++;
            }
            Console.WriteLine(tektoplam + "\t" + cifttoplam);
            */
            #endregion

            #region sayi kadar sayi //1 22 333 4444 55555
            /*
            int i = 0;
            while (i<=5)
            {
                int j = 0;
                while (j<=i)
                {
                    Console.Write(i);
                    j++;
                }
                i++;
            }
            */
            #endregion

            /*
                ***
                ***
                ***
                ***
             */
            #region * dikdortgen
            /*
            int i = 0;
            while (i<4) // satir
            {
                Console.WriteLine();
                int j=0;
                while(j<3) //sutun 
                {
                    Console.Write("*");
                    j++;
                }
                i++;
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

            #region * ucgen
            /*
            //toplam dongu sayisi 5

            int i = 0;// oldugum satir sayisi
            while (i<=5) // satirlari yazdircaz
            {
                int k = 1;
                while (k <= 5- i) //bosluk 4 3 2 1
                {
                    Console.Write(" ");
                    k++;
                    
                }
                int j = 1;
                while (j<=i) // yildiz 1 2 3 4 5
                {
                    Console.Write("*");
                    j++;
                   
                }

                Console.WriteLine();
                i++;
            }
            */
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
               ***
            */

            #region * agac
            /*
            // yukari ucgen dongu sayisi 5 
            int i = 0;
            while (i<=5) // satirlar yazilacak
            {
                int j = 0;
                while (j<=4-i) // bosluk sutuun
                {
                    Console.Write(" ");
                    j++;
                }
                int k = 0;
                while (k<2*i-1) // yildiz sutun 
                {
                    Console.Write("*");
                    k++;
                }
                Console.WriteLine();
                i++;
            }
            //asagi dongu
            int d = 0;
            while (d<=4) // satirlar yazilacak
            {
                int b = 0;
                while (b < 3) // bosluk sutuun
                {
                    Console.Write(" ");
                    b++;
                }
                int a = 0;
                while (a<3) // yildiz sutun 
                {
                    Console.Write("*");
                    a++;
                }
                Console.WriteLine();
                d++;
            }
            */

            #endregion

            /*
                   *
                  ***
                 *****
                *******
                 *****
                  ***
                   *
                   
            */

            #region * baklava dilimi
            /*
            //ust kisim dongu 4 satir
            int a = 0;
            while (a<=4)//satir
            {
                int b = 0;
                while (b<=3-a)// bosluk sutun 
                {
                    Console.Write(" ");
                    b++;
                }
                int c = 0;
                while (c < 2*a-1)// yildiz sutun 
                {
                    Console.Write("*");
                    c++;
                }
                Console.WriteLine();
                a++;
            }
            //asagi dongu 3 satir
            int d = 0;
            while (d <= 4)//satir
            {
                int b = 0;
                while (b <= d)// bosluk sutun 
                {
                    Console.Write(" ");
                    b++;
                }
                int c = 0;
                while (c <= 3-2*d+1)// yildiz sutun 
                {
                    Console.Write("*");
                    c++;
                }
                Console.WriteLine();
                d++;
            }

            */

            #endregion


            #region Fibonacci
            /*
            Console.WriteLine("fibonacci hesaplamsi icin bir sayi gir");
            int sayi = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 1;
            int b = 1;
            int i = 0;
            while (i<sayi)
            {
                Console.Write(a);
                sum = a + b;
                a = b;
                b = sum;
                i++;
            }
            */
            #endregion

            #region asal sayi
            /*
            Console.WriteLine("bir sayi gir ");
            int sayi = int.Parse(Console.ReadLine());
            int i = 2;
            while (i<sayi)
            {
                bool durum = true;
                int j = 2;
                while (j<i)
                {
                    if (i % j == 0)
                    {
                        durum = false;
                        break;
                    }
                    j++;
                }
                if (durum == true)
                {
                    Console.Write(i+" ");

                }
                i++;
            }
            */
            #endregion

            #region 1000 in 1000 haric bolenleri
            /*
            int i = 1;
            while (i<=500)
            {
                if (1000%i==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */
            #endregion

            #region banka denemesi

            int hak = 3;
            int butce = 1000;
            while (hak <= 3)
            {
                if (hak > 0)
                {
                menu:
                    Console.WriteLine("yapmak istediginiz islemi secin ! 1-para cekme\n 2-para gonderme\n 3-bakiye yukleme\n 4-bakiye kontrol\n 5-cikis\n");
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                        a:
                            Console.WriteLine("ne kadar para cekmek istiyorsunuz?");
                            int cekimpara = int.Parse(Console.ReadLine());
                            if (cekimpara > butce)
                            {
                                Console.WriteLine($"{cekimpara} tl cekemezsiniz. en fazla cekebileceginiz ucret {butce}.");
                                goto a;
                            }
                            else { butce -= cekimpara; Console.WriteLine($"kalan paraniz{butce}"); }
                            goto menu;
                        case 2:
                        b:
                            Console.WriteLine("ne kadar para gondermek istiyorsunuz?");
                            int gondermepara = int.Parse(Console.ReadLine());
                            if (gondermepara > butce)
                            {
                                Console.WriteLine($"{gondermepara} tl cekemezsiniz. en fazla gonderebilceginiz ucret {butce}.");
                                goto b;
                            }
                            else { butce -= gondermepara; Console.WriteLine($"kalan paraniz{butce}"); }
                            goto menu;
                        case 3:
                            Console.WriteLine("ne kadar para yukleme istiyorsunuz?");
                            int yuklemepara = int.Parse(Console.ReadLine());
                            butce += yuklemepara; Console.WriteLine($"yeni butceniz {butce}");
                            goto menu;
                        case 4:
                            Console.WriteLine($" hesabinizdaki para : {butce}");
                            goto menu;
                        case 5:
                            hak = 0;
                            Console.WriteLine("iyi gunler");
                            break;
                        default:
                            Console.WriteLine("istediginiz islemi yanlis girdiniz lutefn yeniden deneyin!!");
                            hak -= hak;
                            goto menu;
                    }

                }

                else { Console.WriteLine("butun giris hakkiniz bitti!!!!"); break; }
                hak--;
            }
            #endregion
        }
    }
}
