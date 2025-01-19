using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi ornekleri
            //degiskenTuru [] diziAdi = new degiskenTuru[elemanSayisi]
            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Beyaz";
            //colors[2] = "Sari";
            //colors[3] = "Pembe";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "malatya";
            //cities[2] = "madrid";
            //cities[3] = "elazig";
            //cities[4] = "belgrade";
            //Console.WriteLine(cities[1]);

            //int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(numbers[4]);

            //string[] cities = new string[] { "malatya", "elazig", "urfa", "madrid", "barca", "belgrade" };
            //Console.WriteLine(cities[0]);


            //Console.Read();
            #endregion

            #region dizideki tum elemanlari listeleme

            //string[] colors = { "sari", "kirmizi", "mavi", "yesil", "mor", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayse", "fatma", "ecem", "emre" };
            //Console.WriteLine(persons.Length);

            //array.sort = kucukten buyuge siraliyor

            //int[] numbers = { 2, 1, 3, 4, 5, 9, 58, 7, 6 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //array.reverse = tersten siraliyor

            //int[] numbers = { 2, 1, 3, 4, 5, 9, 58, 7, 6 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.Read();
            #endregion

            #region dizi metotlar

            //string[] customers = { "ali", "buse", "ahmet", "ecem", "melda", "ceren" };
            //int index = Array.IndexOf(customers, "melda");
            //Console.WriteLine(index);

            //int[] numbers = { 14, 22, 33, 45, 25, 56, 77, 84 };
            //Console.WriteLine("dizinin en buyuk elemani: " + numbers.Max() + " dizinin en kucuk elemani: " + numbers.Min());


            //Console.Read();
            #endregion

            #region kullanicidan deger alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lutfen{i + 1}. Sehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 23, 34, 54, 65, 76, 87, 98, 69, 150, 141, 132, 134, 164, 185, 167, 157, 198, 144, 200, 231, 252, 263, 274, 225, 264, 273, 284, 269, 301, 311, 432 };
            //Console.WriteLine("cift sayilar:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("tek sayilar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {

            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.Read();
            #endregion
        }
    }
}
