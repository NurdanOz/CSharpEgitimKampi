using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH DÖNGÜSÜ
            //Foreach(1,2,3,4)


            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //

            //int[] numbers = { 45, 75, 98, 200, 300, 400, 500, 600, 700, 800, 900 };
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //int[] numbers = { 45, 75, 98, 200, 301, 401, 501, 601, 700, 800, 900 };
            //foreach(int nu in numbers)
            //{
            //    if(nu%2==0)
            //    {
            //        Console.WriteLine(nu);
            //    }
            //}

            //int[] numbers = { 45, 75, 98, 200, 300, 400, 500, 600, 700, 800, 900 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int n in numbers)
            //{

            //    Console.WriteLine(n);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region ÖRNEK SINAV SİSTEMİ UYGULAMASI

            //Console.Write("*****C# EĞİTİM KAMPI SINAV UYGULAMASI*****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //SINIFTAKİ ÖĞRENCİ SAYISINI KULLANICIDAN ALMA
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //öğrenci isimlerini ve not ortalamalarını sakyayack diziler
            //string[] studentnames = new string[studentCount];
            //double[] studentexamavg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentnames[i] = Console.ReadLine();
            //    double totalexamresult = 0;

            //    her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentnames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalexamresult += value; // notları topluyoruz

            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    studentexamavg[i] = totalexamresult / 3;


            //}

            //sınav ortalamaları

            //for (int i = 0; i < studentCount; i++)
            //{

            //    Console.WriteLine("----------------------------");


            //    Console.WriteLine($"{studentnames[i]} adlı öğrencinin ortalaması:{studentexamavg[i]} ");

            //    öğrencilerin geçip kalma durumu

            //    if (studentexamavg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentnames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentnames[i]} adlı öğrenci dersten kaldı ");
            //    }

            //    Console.WriteLine("----------------------------");
            //}




            #endregion
        
    Console.Read();


        }
    }
}
