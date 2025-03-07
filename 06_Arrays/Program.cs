using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region TEMEL DİZİ ÖRNEKLERİ
            //aynı veri tipindeki çok sayıda veriyi bir arada tutmak için yapılan 
            //uygulamalara DİZİ denir örneğin çift sayılar kendi içinde bir dizidir
            //sarı,kırmızı,mavi,turuncu,beyaz.......gibi
            //adana,ankara,istanbul,bursa.........gibi
            //değişkentürü [] diziadı=new değişnetürü[eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "mileno";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 46;
            //numbers[3] = 44;
            //numbers[4] = 42;
            //numbers[5] = 40;
            //numbers[7] = 38;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region DİZİDEKİ TÜM ELEMANLARI LİSTELEME

            //string[] colors = { "sarı", "kırmızı", "mavi", "turuncu", "mor", "yeşil", "beyaz" };
            //for(int i=0; i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 1120, 2222 };

            //for (int i=0; i<numbers.Length;i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myarray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxnumber = myarray[0];
            //for( int i=0;i<myarray.Length;i++)
            //{
            //    if (myarray[i]>maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 42, 85, 51, 86, 74, 12, 38, 48, 5, 3, 1 };
            //Array.Sort(numbers);
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            Console.Read();
        }
    }
}
