using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE DEĞİŞKENLER

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;

            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberryprice = 45;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyatı:" + appleprice + "TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı:" + orangeprice + "TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı:" + strawberryprice + "TL");
            //Console.WriteLine("-----Patates Birim Fiyatı:" + potatoprice + "TL");
            //Console.WriteLine("-----Domates Birim Fiyatı:" + tomatoprice + "TL");



            //double applegram, orangegram, strewberrygram, potatogram, tomatogram;

            //applegram = 1.245;
            //orangegram = 2.650;
            //strewberrygram = 0.750;
            //potatogram = 4.85;
            //tomatogram = 3.45;

            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice = orangegram * orangeprice;
            //double strewberrytotalprice = strewberrygram * strawberryprice;
            //double potatototalprice = potatogram * potatoprice;
            //double tomatototalprice = tomatogram * tomatoprice;

            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("Alınan Ürün:Elma- " + "Birim Fiyatı: " + appleprice + "-Gramaj: " + applegram + "-Toplam Tutar: " + appletotalprice);
            //Console.WriteLine("Alınan Ürün:Portakal- " + "-Birim Fiyatı: " + orangeprice + "-Gramaj: " + orangegram + "-Toplam Tutar: " + orangetotalprice);
            //Console.WriteLine("Alınan Ürün:Çilek- " + "Birim Fiyatı: " + strawberryprice + "-Gramaj: " + strewberrygram + "-Toplam Tutar: " + strewberrytotalprice);
            //Console.WriteLine("Alınan Ürün:Patates- " + "Birim Fiyatı: " + potatoprice + "-Gramaj: " + potatogram + "-Toplam Tutar: " + potatototalprice);
            //Console.WriteLine("Alınan Ürün:Domates- " + "Birim Fiyatı: " + tomatoprice + "-Gramaj: " + tomatogram + "-Toplam Tutar: " + tomatototalprice);

            //double shoppingtotalprice = appletotalprice + orangetotalprice + strewberrytotalprice + tomatototalprice + potatototalprice;

            //Console.WriteLine();
            //Console.WriteLine();



            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingtotalprice + "TL");

            #endregion

            #region CHAR DEĞİŞKENLER
            //char symbol;
            //symbol = 'b';

            //Console.WriteLine(symbol);

            #endregion

            #region KLAVYEDEN VERİ GİRİŞLERİ

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage, passengerIdentitynumber;

            //Console.Write("Yolcu Adı:");
            //passengername = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengersurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerage = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentitynumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No:" + passengerIdentitynumber + "-Yolcu Ad Soyad: " + passengername + " " + passengersurname + " " + passengerdistrict + "/" + passengercity + " " + passengerage + " ");


            #endregion

            #region KLAVYEDEN TAM SAYI GİRİŞLERİ ve DÖNÜŞÜMLER

            //int shoeprice, computerprice, chairprice, tvprice;
            //shoeprice = 1000;
            //computerprice = 20000;
            //chairprice = 5000;
            //tvprice = 12000;

            //int shoecount, computercount, chaircount, tvcount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoecount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computercount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chaircount = int.Parse(Console.ReadLine());


            //Console.Write("Lütfen Aldığınız Tv Sayısını Giriniz: ");
            //tvcount = int.Parse(Console.ReadLine());

            //int totalprice = shoecount * shoeprice + computercount * computerprice + chaircount * chairprice + tvcount * tvprice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalprice + "TL");

            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ
            //double exam1, exam2, exam3, result;
            //Console.Write("Lüften 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lüften 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lüften 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama: " + result);

            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();

        }
    }
}
