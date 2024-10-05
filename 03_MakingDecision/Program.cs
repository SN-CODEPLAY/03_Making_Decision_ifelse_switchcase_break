using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            Console.WriteLine("Lütfen şifrenizi giriniz");
            string password= Console.ReadLine();
            if(password == "abcd") {
                Console.WriteLine("Şifre Doğru.");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış.");
            }

            string capital, country;
            Console.WriteLine("Lütfen başkent giriniz.");
            capital = Console.ReadLine();
            Console.WriteLine("Lütfen ülkenizi giriniz");
            country = Console.ReadLine();
            if (capital =="ankara" & country == "türkiye")
            {
                Console.WriteLine("Veriler Doğrulandı.");
            }
            else
            {
                Console.WriteLine("Hatalı Bilgi");
            }

            int number;
            Console.WriteLine("Sayı Giriniz.");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }

            int exam1, exam2, exam3, average;
            string result = "Hata!";
            Console.WriteLine("Sınav 1: ");
            exam1 =int.Parse(Console.ReadLine());
    
            Console.WriteLine("Sınav 2 : ");
           exam2 =int.Parse(Console.ReadLine());
            Console.WriteLine("Sınav 3: ");
            exam3 =int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların ortalaması : " + average);
            if(average>0 & average < 50) {
                result = "Sonuç Kötü";
            }
            if (average> 50&average <= 70){
                result = "sonuç orta";
            
            }
            if (average > 70&average <= 84)
            {
                result = "sonuç iyi";

            }
            if(average>84)
            {
                result = "Çok İyi";
            }
            Console.WriteLine(result);

            string city;
            Console.WriteLine("Lütfen Şehir Giriniz.");
            city = Console.ReadLine();
            if(city=="adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }

            Console.WriteLine("Lütfen kullanıcıadı giriniz");
            string username=Console.ReadLine();
            if(username != "admin")
            {
                Console.WriteLine("bu kullanıcı adı kabul edilemez");
            }
            else
            {
                Console.Write("Hoş Geldiniz");
            }
           





            Console.ReadLine();

            #endregion
            #region Mod İşlemleri
            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            int sayı2=int.Parse(Console.ReadLine());
            int sonuç = sayı1 % sayı2;
            Console.WriteLine("1. Sayının, 2.sayıya bölümünden kalan : " + sonuç);

            Console.WriteLine("Lütfen sayıyı giriniz.");
            int sayı=int.Parse(Console.ReadLine());
            if (sayı % 2 == 2)
            {
                Console.WriteLine("sayı çifttir.");
            }
            else
            {
                Console.WriteLine("sayı tektir.");
            }
            #endregion
            #region Char İşlemleri
            char team;
            Console.WriteLine("Lüten takım sembolünü giriniz.");
            team=char.Parse(Console.ReadLine());
            if(team == 'G' | team=='G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f'| team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
            #endregion
            #region Örnek Proje Uygulaması
            Console.WriteLine("************************ C# EĞİTİM KAMPI RESTORAN **********************");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            string menuItem = (Console.ReadLine());
            if(menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------------- ANA YEMEKLER -------------------------");
                Console.WriteLine();
                Console.WriteLine("1-Köri soslu tavuk");
                Console.WriteLine("2-Kızartma tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("---------------- ANA YEMEKLER -------------------------");
                Console.WriteLine();



            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------------- ÇORBALAR -------------------------");
                Console.WriteLine();
                Console.WriteLine("1-Ezo Gelin Çorbası");
                Console.WriteLine("2-Mercimek Çorbası");
                Console.WriteLine("---------------- ÇORBALAR -------------------------");
                Console.WriteLine();



            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------------- PİZZALAR -------------------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margaritha");
                Console.WriteLine("2-Tavuklu Pizza");
                Console.WriteLine("---------------- PİZZALAR -------------------------");
                Console.WriteLine();



            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------------- İÇECEKLER -------------------------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("---------------- İÇECEKLER -------------------------");
                Console.WriteLine();



            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------------- TATLILAR -------------------------");
                Console.WriteLine();
                Console.WriteLine("1-Künefe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");

                Console.WriteLine("---------------- TATLILAR -------------------------");
                Console.WriteLine();



            }

            #endregion
            #region Switch Case
            Console.WriteLine("Lütfen ay girişi yapınız.");
            int monthNumber =int.Parse(Console.ReadLine());
            switch(monthNumber)
            {
                case 1:Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default:Console.WriteLine("Hatalı Veri Girişi"); break;
                       
            }
            #endregion
            #region Switch Case Hesap Makinesi
            char symbol;
            int resultt, number1,number2; // result'ı int olarak tanımladım
            Console.WriteLine("1. sayıyı giriniz:");
              number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
             number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    resultt = number1 + number2;
                    Console.WriteLine("Sonuç: " + resultt);
                    break;
                case '-':
                    resultt = number1 - number2;
                    Console.WriteLine("Sonuç: " + resultt);
                    break;
                case '*':
                    resultt = number1 * number2;
                    Console.WriteLine("Sonuç: " + resultt);
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        resultt = number1 / number2;
                        Console.WriteLine("Sonuç: " + resultt);
                    }
                    else
                    {
                        Console.WriteLine("Bölme işleminde payda sıfır olamaz.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }

            #endregion

        }
    }
}
