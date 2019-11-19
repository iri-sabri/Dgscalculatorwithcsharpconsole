using System;

namespace DgsCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {


                Console.Write("Sayısal Yetenek Doğru Sayınızı Giriniz: ");
                float saydog = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayısal Yetenek Yanlış Sayınızı Giriniz: ");
                float sayyan = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sözel Yetenek Doğru Sayınızı Giriniz: ");
                float sozdog = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sözel Yetenek Yanlış Sayınızı Giriniz: ");
                float sozyan = Convert.ToInt32(Console.ReadLine());
             if (saydog > 60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();
            }
             else if (sayyan >  60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();

            }
             else if (sozdog > 60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();

            }
             else if (sozyan > 60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();

            }
            else if (saydog + sayyan > 60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();
            }
            else if (sozdog + sozyan > 60)
            {
                Console.Write("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
                Console.ReadKey();           
            }
             else
            {


                Console.Write("Önlisans Başarı Puanınızı Giriniz (100 lük sistemden giriniz) ");
                float obp = Convert.ToInt32(Console.ReadLine());
                float obpreal = (float)(obp * 0.8);
                if (obpreal < 40)
                {
                    Console.WriteLine("Önlisans Başarı Puanınız 50 den Küçük olamaz!");
                }
                else
                {

                    float sayisalnot, sozelnot, esitagirliknot, sayreal, sozreal;

                    sayisalnot = (float)(saydog - (sayyan * 0.25));
                    sozelnot = (float)(sozdog - (sozyan * 0.25));



                    sayreal = (float)(145.442 + (sozelnot * 0.498) + (sayisalnot * 3.135) + (obpreal * 0.6));

                    if (sayreal < 180)
                    {
                        Console.WriteLine("Sayısal Puan Türünden Barajı Geçemediniz");
                    }
                    else
                    {
                        Console.WriteLine("Sayısal Puanınız: " + sayreal);

                    }
                    sozreal = (float)(121.342 + (sozelnot * 2.489) + (sayisalnot * 0.627) + (obpreal * 0.6));
                    if (sozreal < 180)
                    {
                        Console.WriteLine("Sözel Puan Türünden Barajı Geçemediniz");
                    }
                    else
                    {
                        Console.WriteLine("Sözel Puanınız: " + sozreal);

                    }



                    esitagirliknot = (float)(133.392 + (sayisalnot * 1.494) + (sozelnot * 1.881) + (obpreal * 0.6));
                    if (esitagirliknot < 180)
                    {
                        Console.WriteLine("Eşit Ağırlık Puan Türünden Barajı Geçemediniz");
                    }
                    else
                    {
                        Console.WriteLine("Eşit Ağırlık Puanınız Puanınız: " + esitagirliknot);

                    }
                    Console.WriteLine("UYARI!  Standart Sapma Sebebi ile küçük puan farkları olabilir ");
                    Console.ReadKey();


                }


            }

        }
      }
    }

