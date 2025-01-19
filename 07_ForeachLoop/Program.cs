using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach dongusu

            //foreach(1;2;3;4)
            //1=degisken turu
            //2=degisken adi
            //3=in
            //4=liste, koleksiyon, dizi adi

            //string[] cities = { "milano", "istanbul", "ankara", "belgrade", "warsaw", "kiev" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 15, 22, 43, 34, 245, 623, 734, 10983 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = { 15, 22, 43, 34, 245, 623, 734, 10983 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 15, 22, 43, 34, 245, 623, 734, 10983 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9,10
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            //Console.Read();
            #endregion

            #region ornek sinav sistemi uygulamasi

            Console.WriteLine("***** C# Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //siniftaki ogrenci sayisini kullanicidan alma
            Console.WriteLine("------------------------------");
            Console.Write("sinifinizda kac ogrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //ogrenci isimlerini ve not ortalamalarini saklayacak diziler
            string[] studentsNames = new string[studentCount];
            double[] studentsExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. ogrencinin ismini giriniz: ");
                studentsNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her ogrenci icin 3 sinav notu girisi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsNames[i]} isimli ogrencinin {j + 1}. sinaav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notlari topluyoruz
                }
                Console.WriteLine();
                studentsExamAvg[i] = totalExamResult / 3;
            }

            //sinav ortalamalari

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"{studentsNames[i]} isimli ogrencinin ortalamasi: {studentsExamAvg[i]}");

                //ogrencilerin ortalamasi ve gecip kalma durumu
                if (studentsExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsNames[i]} adli ogrenci dersten gecti");
                }
                else
                {
                    Console.WriteLine($"{studentsNames[i]} adli ogrenci dersten kaldi");
                }
                Console.WriteLine("-----------------------------------------------");
            }




            Console.Read();
            #endregion
        }
    }
}
