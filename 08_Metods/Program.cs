using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region METOTLAR
            //()
            //1-GERİYE DEĞER DÖNDÜRMEYEN METOTLAR
            //CUSTOMER-----> LİSTELE,EKLE,SİL,GÜNCELLE----->VOİD METOTLAR


            //örnekler
            //void customerlist()
            //{
            //    Console.WriteLine("ALİ YILDIZ");
            //    Console.WriteLine("AYŞE YILDIZ");
            //    Console.WriteLine("HAKAN ÖZTÜRK");
            //    Console.WriteLine("MERVE ÇINAR");
            //}

            //customerlist();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN STRİNG PARAMETLERELİ METOTLAR
            //void writemethod(string customername)
            //{
            //    Console.WriteLine(customername);
            //}
            //writemethod("mehmet yıldırm");

            //void customercard(string name, string surName)
            //{

            //    Console.WriteLine("müşteri:" + name + " " + surName);
            //}

            //customercard("Mehmet", "YILDIZ");
            //customercard("ayşegül", "kaya");

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN İNT PARAMETLERELİ METOTLAR

            //void Sum(int number1,int number2, int number3)
            // {
            //     int result = number1 + number2 + number3;
            //     Console.WriteLine(result);
            // }

            // Sum(4, 5, 6);




            #endregion

            #region GERİYE DEĞER DÖNDÜREN METOTLAR

            //string customername()

            //{
            //    return "buse yıldız";
            //}

            //customername();

            //string studentcard()
            //{
            //    string name = "ali";
            //    string surname = "tıldız";
            //    return name + " " + surname;

            //}

            //Console.WriteLine(studentcard());


            #endregion

            #region GERİYE DEĞER DÖNDÜREN STRİNG PARAMETRELİ METOTLAR

            // string countrycard(string countryname, string capital, string flagcolor)
            // {
            //     string cardınfo ="ülke:"+ countryname + " - başkent: " + capital + " -bayrak rengi: " + flagcolor;
            //     return cardınfo;
            // }

            // string x, y, z;
            // Console.Write("ülke adını giriniz: ");
            // x = Console.ReadLine();

            // Console.Write("başkenti giriniz: ");
            // y = Console.ReadLine();

            // Console.Write("bayrak rengi giriniz: ");
            // z = Console.ReadLine();

            //Console.Write( countrycard(x, y, z));



            #endregion

            #region GERİYE DEĞER DÖNDÜREN İNT PARAMETRELİ METOTLAR

            //int sum (int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36,25));
            //Console.WriteLine(sum(44, 52));
            //Console.WriteLine(sum(55,88));


            #endregion


            #region örnek uygulama

            //string examresult(string student, int exam1,int exam2, int exam3)

            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result>=50)
            //    {
            //        return student + " isimli ÖĞrenci sınavı geçti" + "ortalama:" + result;
            //    }
            //    else
            //    {
            //        return student +" isimli öğrenci başarısız oldu" + "ortalama:" + result;
            //    }

            //}

            //Console.WriteLine(examresult("ali",25,41,85));
            //Console.WriteLine(examresult("ayşe",36,88,10));

            #endregion


            Console.Read();

        }
    }
}
