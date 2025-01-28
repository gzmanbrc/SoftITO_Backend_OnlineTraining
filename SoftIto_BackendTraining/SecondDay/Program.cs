using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int g = int.Parse(Console.ReadLine());    ==    int ga = Convert.ToInt32(Console.ReadLine());

            #region atama operatorleri 

            #endregion

            #region 3 sayinin karsilastirilmasi
            /*

            int s1 = 10;
            int s2 = 20;
            int s3 = 30;
            if (s1 != s2 && s2 != s3 && s1 != s3)
            {
                if (s1 > s2 && s1 > s3)
                {
                    if (s2 > s3) { }
                    else { }
                }
                else if (s2 > s1 && s2 > s3)
                {
                    if (s1 > s3) { }
                    else { }
                }
                else
                {
                    if (s2 > s1) { }
                    else { }
                }
            }
            else 
            { }
            */
            #endregion


            #region girilen sayinin pozitif negatif veya notr olma ihtimaline bak
            /*
            Console.WriteLine("bir sayi giriniz!");
            int sayi5 = int.Parse(Console.ReadLine());

            if (sayi5 > 0) { Console.WriteLine("sayi pozitif!"); }
            else if (sayi5 <0) { Console.WriteLine("sayi negatif!"); }
            else { Console.WriteLine("sayi notr!");  }
            */
            #endregion


            #region 3 mal aliniyor eger mallarin toplami 1000den kucukse  %5 buyukse %3
            /*
            Console.WriteLine("birinci alinan mallarin fiyatini giriniz!");
            int sayi6 = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci alinan mallarin fiyatini giriniz!");
            int sayi7 = int.Parse(Console.ReadLine());
            Console.WriteLine("ucuncu alinan mallarin fiyatini giriniz!");
            int sayi8 = int.Parse(Console.ReadLine());

            double toplammalfiyati = sayi6 + sayi7 + sayi8;

            if (toplammalfiyati >= 1000)
            { toplammalfiyati = toplammalfiyati * 1.03;
                Console.WriteLine("toplam mal fiyati = " + toplammalfiyati);
            }

            else if (toplammalfiyati < 1000)
            {
                toplammalfiyati = toplammalfiyati * 1.05;
                Console.WriteLine("toplam mal fiyati = " + toplammalfiyati);
            }
            */

            #endregion

            #region hesap makinesi denemesi
            /*
            
            Console.WriteLine("bir sayi giriniz!");
            double sayi9 = double.Parse(Console.ReadLine());
            tekrar:
            Console.WriteLine("bir sayi giriniz!");
            double sayi10 = double.Parse(Console.ReadLine());
            tekraroperator:
            Console.WriteLine("lutfen bir oprerator seciniz!");
            string isaret = Console.ReadLine();
            double sum = 0;

            if (isaret == "+")
            {
                sum = sayi9 + sayi10;
                Console.WriteLine("sayilarin toplami" + sum);
                
            }
            else if (isaret == "-")
            {
                sum = sayi9 - sayi10;
                Console.WriteLine("sayilarin toplami" + sum);
                
            }
            else if (isaret == "*")
            {
                if (sayi10 > 0)
                {
                    sum = sayi9 * sayi10;
                    Console.WriteLine("sayilarin toplami" + sum);
                }
                else { Console.WriteLine("lutfen ikinci sayiyi 0 dan farkli girin!"); }
                
            }
            else if (isaret == "/")
            {
                sum = sayi9 / sayi10;
                Console.WriteLine("sayilarin toplami" + sum);
                
            }
            else { Console.WriteLine("yanlis operator sectin!"); goto tekraroperator; }
            goto tekrar;
            */

            #endregion

            #region puan hesaplama
            // okul max 60 puan veriyor osym toplam 160soru 40 fen, mat sosyal, turkce
            // 4 yanlis 1 soru goturuyor. max puan 500 sorularin katsayisi 3 


            double trNet;
            double fNet;
            double mNet;

            Console.WriteLine("lutfen okul puaninizi giriniz");
            double okulpuani = double.Parse(Console.ReadLine());
            if (okulpuani <= 100) { okulpuani = okulpuani * 0.6; }
            else { Console.WriteLine("okul puaniniz 100den fazla olamaz!!!!!!!"); }
            T:
            Console.WriteLine("turkce dogru sayisi");
            double trD = double.Parse(Console.ReadLine());

            Console.WriteLine("turkce yanlis sayisi");
            double trY = double.Parse(Console.ReadLine());

            Console.WriteLine("turkce bos sayisi");
            double trB = double.Parse(Console.ReadLine());

            if (trB + trD + trY == 40) { trNet = trD - trY * 0.25; Console.WriteLine("turkce netiniz: " + trNet); }
            else { Console.WriteLine("soru sayisi toplam 40 dan fazla olamaz tekrar gir!!!"); goto T; }

            F:
            Console.WriteLine("fen dogru sayisi");
            double fD = double.Parse(Console.ReadLine());

            Console.WriteLine("fen yanlis sayisi");
            double fY = double.Parse(Console.ReadLine());

            Console.WriteLine("fen bos sayisi");
            double fB = double.Parse(Console.ReadLine());

            if (fB + fD + fY == 40) { fNet = fD - fY * 0.25; Console.WriteLine("fen netiniz: " + fNet); }
            else { Console.WriteLine("soru sayisi toplam 40 dan fazla olamaz tekrar gir!!!"); goto F; }

            M:
            Console.WriteLine("mat dogru sayisi");
            double mD = double.Parse(Console.ReadLine());

            Console.WriteLine("mat yanlis sayisi");
            double mY = double.Parse(Console.ReadLine());

            Console.WriteLine("mat bos sayisi");
            double mB = double.Parse(Console.ReadLine());

            if (mB + mD + mY == 40) { mNet = mD - mY * 0.25; Console.WriteLine("matematik netiniz: " + mNet); }
            else { Console.WriteLine("soru sayisi toplam 40 dan fazla olamaz tekrar gir!!!"); goto M; }


            trNet = trD - trY * 0.25; fNet = fD - fY * 0.25; mNet = mD - mY * 0.25;
            double topNet = trNet + mNet + fNet;

            double puan = topNet * 3 + okulpuani + 150;
            Console.WriteLine("Sinav Puaniniz: " + puan);
            Console.ReadLine();
            #endregion
        }
    }
}