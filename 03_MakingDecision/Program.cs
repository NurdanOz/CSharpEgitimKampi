using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE

            //Console.Write("lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //Console.Read();

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")

            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}

            //Console.Read();

            //int sayi;

            //Console.Write("sayıyı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            // if (sayi==5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}


            //int exam1, exam2, exam3, average;
            //string result= "Hata!";


            //Console.Write("sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());


            //Console.Write("sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());


            //Console.Write("sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average>0 & average<=50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average>50 & average<=70)
            //{
            //    result = "sonuç orta";
            //}
            //if(average>70 & average<=84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average>84)
            //{
            //    result = "sonuç çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}




            //Console.Read();


            #endregion

            #region MOD İŞLEMLERİ


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lüften 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);


            //Console.Write("lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2==0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}


            //char team;
            //Console.Write( " lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team=='f' | team=='F' )
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team=='b' | team=='B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            //Console.Read();

            #endregion

            #region CHAR DEĞİŞKENLER İLE KARAR YAPILARI

            //Console.WriteLine("******C^# Eğitim kampı restoran******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------");
            //Console.WriteLine();

            //string menuıtem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuıtem = Console.ReadLine();

            //if (menuıtem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-köri soslu tavuk");
            //    Console.WriteLine("2-kızartma tabağı");
            //    Console.WriteLine("3-fasulye pilav");
            //    Console.WriteLine("4-fırında somon");
            //    Console.WriteLine("5-patlıcan musakka");
            //    Console.WriteLine("---------Ana Yemekler----------");

            //    Console.WriteLine();


            //}

            //if (menuıtem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------ÇORBALAR-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-MERCİMEK");
            //    Console.WriteLine("2-EZOGELİN");
            //    Console.WriteLine("3-TAVUK");



            //    Console.WriteLine();


            //}


            //if (menuıtem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------PİZZALAR-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-AKDENİZ PİZZA");
            //    Console.WriteLine("2-MARGARİTA");
            //    Console.WriteLine("3-TAVUKLU PİZZA");



            //    Console.WriteLine();


            //}


            //if (menuıtem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------İÇECEKLER-------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-KOLA");
            //    Console.WriteLine("2-AYRAN");
            //    Console.WriteLine("3-SU");



            //    Console.WriteLine();


            //}

            //if (menuıtem == "5")

            //    Console.Read();

            #endregion

            #region SWİTCH CASE

            //Console.Write("lütfen ay girişi yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1: Console.Write("ocak"); break;
            //    case 2: Console.Write("şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;

            //    default: Console.Write("hatalı veri girişi"); break;
            //}

            //Console.Read();

            #endregion

            #region SWİTCH CASE HESAP MAKİNASI

            //int number1, number2, result;
            //char symbol;


            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplam:" + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark:" + result); break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım:" + result); break;


            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm:" + result); break;


            //}

            //Console.Read();

            #endregion




        }
    }
}
