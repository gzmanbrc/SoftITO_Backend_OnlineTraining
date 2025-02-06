using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCafeSystem//05.02.2025 - 06.02.2025//  -- En ilkel haliyle kafe sistemi
{
    internal class Program // sadece if- if else -else ,for , switch-case, diziler kullanilicak
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("*\t\t\t\t\t*");
                Console.WriteLine("*\t\t\t\t\t*");
                Console.WriteLine("* \tKafeye Hosgeldiniz!!\t\t*");
                Console.WriteLine("*\t\t\t\t\t*");
                Console.WriteLine("*\t\t\t\t    ->\t*");
                Console.WriteLine("*\t\t\t\t\t*");
                Console.WriteLine("*****************************************");
                Console.ReadKey();
                break;
            }
            Console.Clear();

            #region menu
            // menu
            string[] tatli =
            {
                "1- Magnolia    50tl",
                "2- Tiramisu    90tl",
                "3- Sutlac      60tl",
                "4- Kazandibi   70tl",
            };
            string[] icecek =
            {
                "1- Cay       30tl",
                "2- Latte     60tl",
                "3- Limonata  50tl",
                "4- Gazoz     40tl",
            };

            int[] tatli_fiyat = {50,90,60,70 };
            int[] icecek_fiyat = { 30,60,50,40};

            string[] secilenTatli = new string[4];
            string[] secilenIcecek = new string[4];
            int tatliIndex = 0, icecekIndex = 0;

            #endregion

            #region masa

            string[] masasayisi = { "masa1", "masa2","masa3", "masa4"};
            bool[] masadurum = { true, true, true, true };
            string secilenmasa = "Masa";
            #endregion

            int tatli_son_fiyat = 0;
            int icecek_son_fiyat = 0;
            int total_fiyat = 0;
            

        anamenu:
            Console.WriteLine("\t\t ANA MENU");
            Console.WriteLine("Masa ac       [1]");
            Console.WriteLine("Masa Islem    [2]");
            Console.WriteLine("Masa hesap    [3]");
            Console.WriteLine("Kasa Islemleri[4]");
            Console.WriteLine("cikis yap     [0]");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1: //masa secimi

                    Console.Clear();
                    Console.WriteLine("---------------------");
                    Console.WriteLine("\tMasalar");

                    for (int i = 0; i < masasayisi.Length; i++)
                    {
                        Console.WriteLine(masasayisi[i] + ":" + (masadurum[i] ? "bos" : "dolu"));
                    }
                    b:
                    Console.WriteLine("----------------");
                    Console.WriteLine("hangi masayi istersiniz?");
                    int x = int.Parse(Console.ReadLine());
                    if (masadurum[x-1]==true) 
                    { masadurum[x-1] = false; Console.WriteLine("secilen masa :" + masasayisi[x - 1]); }
                    else 
                    { Console.WriteLine("bu masa dolu baska masa seciniz!!!"); goto b; }
                    Console.Clear();
                    secilenmasa = masasayisi[x - 1];
                    Console.WriteLine(secilenmasa+" dolduruldu.");


                    Console.WriteLine("Ana menüye dönmek için ESC tuşuna basabilirsiniz.");

                    ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Kullanıcının tuş girişini al

                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        goto anamenu; // ESC basıldığında ana menüye dön
                    }
                    break;


                case 2: //menu secimi

                    Console.Clear();
                    Console.WriteLine("-------  MENU  -------");
                    Console.WriteLine("  ");
                    for (int i = 0; i < 4; i++)
                    {
                        string tatli_string = tatli[i];
                        string icecek_string = icecek[i];
                        string menu = tatli_string + "  " + icecek_string;
                        Console.WriteLine(menu);
                    }
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");
                    Console.WriteLine("--------------------------");
                    //tatli alimi
                    Console.WriteLine("tatli almak ister misiniz?");
                     string tonay = Console.ReadLine();

                    while (tonay == "evet" || tonay == "yes" || tonay == "y")
                    {
                        Console.WriteLine("hangi tatliyi istiyorsunuz?");
                        int tatlisecim = int.Parse(Console.ReadLine());
                        tatli_son_fiyat += tatli_fiyat[tatlisecim - 1];

                        secilenTatli[tatliIndex] = tatli[tatlisecim - 1];
                        tatliIndex++;

                        Console.WriteLine("baska almak istediginiz tatli var mi ?");
                        tonay = Console.ReadLine();
                      
                    }
                    //Console.Clear();
                    //Console.WriteLine(tatli_son_fiyat);
                    
                    //icecek alimi
                    Console.WriteLine("icecek almak ister misiniz?");
                    string ionay = Console.ReadLine();

                    while (ionay == "evet" || ionay == "yes" || ionay == "y")
                    {
                        Console.WriteLine("hangi icecegi istiyorsunuz?");
                        int iceceksecim = int.Parse(Console.ReadLine());
                        icecek_son_fiyat += icecek_fiyat[iceceksecim - 1];

                        secilenIcecek[icecekIndex] = icecek[iceceksecim - 1];
                        icecekIndex++;

                        Console.WriteLine("baska almak istediginiz icecek var mi ?");

                        ionay = Console.ReadLine();
                    }
                    Console.Clear();

                    Console.WriteLine("sectiginiz menu:");
                    Console.WriteLine("Tatlılar:");
                    for (int i = 0; i < tatliIndex; i++)
                    {
                        Console.WriteLine(secilenTatli[i]);
                    }
                    Console.WriteLine("İçecekler:");
                    for (int i = 0; i < icecekIndex; i++)
                    {
                        Console.WriteLine(secilenIcecek[i]);
                    }

                    //Console.WriteLine(icecek_son_fiyat);
                    total_fiyat = tatli_son_fiyat + icecek_son_fiyat;
                    //Console.WriteLine(total_fiyat);


                    Console.WriteLine("Ana menüye dönmek için ESC tuşuna basabilirsiniz.");

                    ConsoleKeyInfo keyInfo2 = Console.ReadKey(true); // Kullanıcının tuş girişini al

                    if (keyInfo2.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        goto anamenu; // ESC basıldığında ana menüye dön
                    }
                    break;


                case 3: //masayi ve hesap tutarini gorme

                    Console.WriteLine(secilenmasa + "'nin hesabi"+total_fiyat);
                    Console.WriteLine("Afiyet olsun!!");

                    Console.WriteLine("Ana menüye dönmek için ESC tuşuna basabilirsiniz.");

                    ConsoleKeyInfo keyInfo3 = Console.ReadKey(true); // Kullanıcının tuş girişini al

                    if (keyInfo3.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        goto anamenu; // ESC basıldığında ana menüye dön
                    }
                    break;

                case 4: // kasa islemleri
                    d:
                    Console.WriteLine("Hesabi nasil odemek istersiniz?\n 1- nakit 2-kart" );
                    int y = int.Parse(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            Console.WriteLine("odemeniz gereken tutar ;"+total_fiyat);
                            Console.WriteLine("Tekrar Bekleriz !!");
                            break;
                        case 2:
                            Console.WriteLine("odemeniz gereken tutar ;" + total_fiyat);
                            Console.WriteLine("Tekrar Bekleriz !!");
                            break;
                        default:
                            Console.WriteLine("yanlis tusa bastiniz odeme icin tekrar deneyin!!");
                            goto d;
                    }


                    Console.WriteLine("Ana menüye dönmek için ESC tuşuna basabilirsiniz.");

                    ConsoleKeyInfo keyInfo4 = Console.ReadKey(true); // Kullanıcının tuş girişini al

                    if (keyInfo4.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        goto anamenu; // ESC basıldığında ana menüye dön
                    }
                    break;
                case 0:
                    Console.WriteLine("cikis yapiliyor...");
                    break;
                default:
                    Console.WriteLine("yanlis secim yaptiniz!! yeniden ana menuye yonlendirileceksiniz");
                    goto anamenu;
            }

        }
    }
}
