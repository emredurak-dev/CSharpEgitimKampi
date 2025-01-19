using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for dongusu

            //for(x;y;z)
            //x=baslangic degeri
            //y=bitis degeri
            //z=artis-azalis degeri

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("CSharp Egitim Kampi");
            //}


            //for (int i = 23; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lutfen ekrana yazilmasini istediginiz adedi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i + "-CSharpEgitimKampi");
            //}
            //Console.Read();
            #endregion

            #region for dongusu ile karar yapilari
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i <= 20; i += 2)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);
            //Console.Read();

            //int totalValue = 0;
            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1 den 50 ye kadar olan sayilardan kactanesi 7 ye tam bolunuyor: " + count);
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1 den 50 ye kadar olan sayilardan 7 ye tam bolunenlerin toplami: " + totalValue);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{

            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bacterium);
            //}
            //Console.Read();
            #endregion

            #region while dongusu
            //while (sart)
            //{
            //islemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Yasa Mustafa Kemal Pasa Yasa");
            //    i++;
            //}
            //Console.Read();
            #endregion

            #region while dongusu ile karar yapilari
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.Read();
            #endregion

            #region ornek sinav sorusu
            // klavyeden girilen 3 basamakli sayinin basamaklarinin toplamini hesaplayan kodu yaziniz.
            int number;
            Console.Write("bir sayi giriniz: ");
            number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

           

            Console.Read();
            #endregion
        }
    }
}
