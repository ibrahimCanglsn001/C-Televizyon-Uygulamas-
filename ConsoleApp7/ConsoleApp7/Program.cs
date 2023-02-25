using System;
using System.Numerics;
using System.Threading;

namespace Televizon
{
    class televizyon
    {
        public void kanallar()
        {
        b:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| Aşağıdaki Seçeneklerden İzlemek İstediğiniz Kanalı Seçiniz  |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| GS  TV  İçin '1' Tuşuna Basınız                             |");
            Console.WriteLine("| FB  TV  İçin '2' Tuşuna Basınız                             |");
            Console.WriteLine("| BJK TV  İçin '3' Tuşuna Basınız                             |");
            Console.WriteLine("| TRT 1   İçin '4' Tuşuna Basınız                             |");
            Console.WriteLine("| Kapatmak İçin  'k' Tuşuna Basınız                           |");
            Console.WriteLine("--------------------------------------------------------------");
            string kanal = (Console.ReadLine());
            Console.Clear();
            if (kanal == "1")
            {


                Console.WriteLine("GS TV Açılıyor...");
                Thread.Sleep(500);
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      | GS TV                                                             1 |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      |                               Vestel  .                             |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                goto b;
            }
            if (kanal == "2")
            {
                Console.WriteLine("FB  TV Açılıyor...");
                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      | FB TV                                                             2 |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      |                               Vestel  .                             |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                goto b;
            }
            if (kanal == "3")
            {
                Console.WriteLine("BJK TV  Açılıyor...");
                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      | BJK TV                                                            3 |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      |                               Vestel  .                             |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                goto b;
            }
            if (kanal == "4")
            {
                Console.WriteLine("TRT 1 Açılıyor...");
                Thread.Sleep(500);
                Thread.Sleep(500);
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      | TRT 1 TV                                                          4 |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      |                               Vestel  .                             |");
                Console.WriteLine("                      -----------------------------------------------------------------------");

                goto b;
            }
                if (kanal == "k")
                {

                 
                    Console.WriteLine("Televizyon Kapanıyor...");
                 q:
                    Thread.Sleep(1000);
                    Console.Clear(); 
                    Console.WriteLine("                      -----------------------------------------------------------------------");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      -----------------------------------------------------------------------");
                    Console.WriteLine("                      |                               Vestel                                |");
                    Console.WriteLine("                      -----------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Televizyonu Tekrar Açmak İçin '1' Tuşuna Basınız");
                
                  int secim = Convert.ToInt32(Console.ReadLine());
                  if (secim == 1)
                {
                    Console.WriteLine("Açılıyor...");                   
                }
                  else 
                {
                    if (secim != 1)
                    Console.WriteLine("Televizyonu Açmak İçin Lütfen Doğru Tuşa Basınız");
                    goto q;
                }  

                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      | Tv                                                                  |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      |                                                                     |");
                Console.WriteLine("                      -----------------------------------------------------------------------");
                Console.WriteLine("                      |                               Vestel  .                             |");
                Console.WriteLine("                      -----------------------------------------------------------------------");

                goto b;
            }
                else
                {
                    Console.WriteLine("Lütfen Doğru Tuşa Basınız!");
                    Thread.Sleep(1000);
                   Console.Clear();
                goto b;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            a:
                Console.Clear();
                televizyon televizyon1 = new televizyon();
                Console.WriteLine("Televizyonu Açmak İçin Kumanda da ki '1' Tuşuna Basınız");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Açılıyor...");
                }
                else if (secim != 1)
                {
                Console.WriteLine("Lütfen Doğru Tuşa Basınız");
                Thread.Sleep(1000);
                goto a;
                }
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("                      -----------------------------------------------------------------------");
                    Console.WriteLine("                      | Tv                                                                  |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      |                                                                     |");
                    Console.WriteLine("                      -----------------------------------------------------------------------");
                    Console.WriteLine("                      |                               Vestel  .                             |");
                    Console.WriteLine("                      -----------------------------------------------------------------------");

                    televizyon1.kanallar();
                    Console.ReadKey();

                }
            }
        }
    }
