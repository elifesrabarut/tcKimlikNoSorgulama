using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcKimlikNo.tcKimlik;

namespace tcKimlikNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tc Kimlik Noyu Giriniz:");
            string tcNo = Console.ReadLine();
            string a = tcNo.Substring(0, 5);
            string b = tcNo.Substring(5, 4);
            KPSPublicSoapClient sorgula = new KPSPublicSoapClient();
          
            int toplam = 0; int toplam2 = 0; int toplam3 = 0;
            if (tcNo.Length == 11)
            {
                if (Convert.ToInt32(tcNo[0].ToString()) != 0)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            toplam = toplam + Convert.ToInt32(tcNo[j]);
                            toplam = toplam + 3;
                        }
                        //if (tcNo.Substring(0, 5) != "")
                        //{
                        //    toplam = toplam + Convert.ToInt32(tcNo[j]);
                        //    toplam = toplam + 3;
                        //}
                    }
                         for (int j = 5; j < 10; j++)
                        {
                             if (tcNo.Substring(5, 4) != "")
                            {
                                  toplam2 = toplam2 + Convert.ToInt32(tcNo[j]);
                                  toplam2 = toplam2 - 1;
                                  toplam2 = toplam2 + Convert.ToInt32(tcNo[9]);
                             }
                         }
                        for (int J = 10; J < 11; J++)
                         {
                             if (tcNo[10] > 4)
                             {
                                toplam3 = tcNo[10] - 4;
                             }
                             else
                             {
                                int sayi = tcNo[10];
                                string kucuksayi = sayi.ToString("1");
                                int sayi2 = Convert.ToInt32(kucuksayi);
                                toplam3 = sayi2 - 4;
                             }
                         }
                    Console.WriteLine(toplam.ToString()+toplam2.ToString()+toplam3.ToString());
                }
        else
        {
            Console.WriteLine("11 haneli tc giriniz");
        }

       Console.ReadKey();
            }

        }
    }
}

