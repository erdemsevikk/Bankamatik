using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uygulama : Bankamatik

            //bakiye

            // para yatırma

            //para çekme

            //çıkış

            string secim = "";
            double bakiye = 0;
            double ekHesap = 1000;
            double ekHesapLimiti = 1000;
            do
            { 
            Console.WriteLine("1-Bakiye Görüntüleme\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz:");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz {0} TL", bakiye);
                        Console.WriteLine("Ek hesap bakiyeniz {0}", ekHesap);
                    break;
                case "2":
                    Console.WriteLine("Yatırmak istediğiniz miktar:");
                        double yatirilan = double.Parse(Console.ReadLine());
                        if (ekHesap < 1000)
                        {
                            double ekHesaptanKullanilan = ekHesapLimiti - ekHesap;
                            if (yatirilan > ekHesaptanKullanilan)
                            {
                                ekHesap = ekHesapLimiti;
                                bakiye = yatirilan - ekHesaptanKullanilan;
                            }
                            else
                            {
                                ekHesap += yatirilan;
                            }
                        }
                        else
                        {
                            bakiye += yatirilan;
                        }
                    break;
                case "3":
                    Console.WriteLine("çekmek istediğiniz miktar:");
                        double cekilecekmiktar = double.Parse(Console.ReadLine());
                        if (cekilecekmiktar>bakiye)
                        {
                            double toplam = bakiye + ekHesap;
                            if (toplam > cekilecekmiktar)
                            {
                                Console.WriteLine("Ek hesap kullanılsın mı ? (e/h)");
                                string ekHesapTercihi = Console.ReadLine();

                                if (ekHesapTercihi=="e")
                                {
                                    Console.WriteLine("Paranızı alabilirsiniz.");
                                    ekHesap -= (cekilecekmiktar - bakiye);
                                    bakiye = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyeniz Yeteriz.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Parayı alabilirsiniz.");
                            bakiye -= cekilecekmiktar;
                        }
                    break;
                case "4":
                    Console.WriteLine("çıkış");
                    break;
                default:
                    break;
            }
            } while (secim!="4");
            Console.WriteLine("Uygulamadan çıkıldı.");

            Console.ReadLine();
        }
    }
}
