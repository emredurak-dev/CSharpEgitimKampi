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
            #region if else
            //Console.Write("Lutfen sifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("sifre dogru");
            //}
            //else
            //{
            //    Console.WriteLine("sifre yanlis");
            //}
            //Console.Read();

            //string capital, country;
            //Console.Write("baskenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("ulkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.WriteLine("veriler dogrulandi");
            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlis");
            //}
            //Console.Read();

            //int number;
            //Console.Write("sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 4)
            //{
            //    Console.WriteLine("dogru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlis");
            //}
            //Console.Read();

            //int exam1, exam2, exam3, average;

            //string result="hata";

            //Console.Write("sinav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sinav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sinav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 & average <= 50)
            //{
            //    result = "ortalama: " + average + " / cok kotu";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "ortalama: " + average + " / orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "ortalama: " + average + " / iyi";
            //}
            //if (average > 84)
            //{
            //    result = "ortalama: " + average + " /  masallah";
            //}
            //Console.WriteLine(result);
            //Console.Read();


            //string city;
            //Console.Write("lutfen sehir giriniz: ");
            //city = Console.ReadLine();
            //if (city == "malatya" | city == "ankara" | city == "elazig")
            //{
            //    Console.WriteLine("sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("sehir mevcut degil");
            //}
            //Console.Read();


            //Console.Write("lutfen kullanici adini giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanici kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hosgeldiniz");
            //}
            //Console.Read();
            #endregion

            #region mod islemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Read();

            //Console.Write("birinci sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("birinci sayinin ikinci sayiya bolumunden kalan: " + result);
            //Console.Read();

            //Console.Write("lutfen sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("sayi cifttir");
            //}
            //else
            //{
            //    Console.Write("sayi tektir");
            //}
            //Console.Read();
            #endregion

            #region char degiskenler ile karar yapilari
            //klavyeden girilen harfe gore takim adini yazdir
            //char teams;
            //Console.Write("takim adinin bas harfini giriniz: ");
            //teams = char.Parse(Console.ReadLine());
            //if (teams == 'g' | teams == 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if (teams == 'f' | teams == 'F')
            //{
            //    Console.WriteLine("fenerbahce");
            //}
            //if (teams == 'b' | teams == 'B')
            //{
            //    Console.WriteLine("besiktas");
            //}
            //Console.Read();
            #endregion

            #region ornek proje uygulamasi
            ////restoran uygulamasi
            //Console.WriteLine("***** CSharp Restaurant *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("detayini gormek istediginiz menuyu seciniz: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Akcadag Pilavi");
            //    Console.WriteLine("5-Firinda Somon");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Corbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Yayla Corbasi");
            //    Console.WriteLine("3-Ezogelin Corbasi");
            //    Console.WriteLine("4-Sehriye Corbasi");
            //    Console.WriteLine("5-Kelle Paca");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Corbalar ----------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Special Pizza");
            //    Console.WriteLine("2-Bol Malzemos");
            //    Console.WriteLine("3-Pepperoni");
            //    Console.WriteLine("4-Sosislim");
            //    Console.WriteLine("5-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Icecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Salgam");
            //    Console.WriteLine("5-Hosaf");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Icecekler ----------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlilar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kunefe");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Kadayif");
            //    Console.WriteLine("4-Burma");
            //    Console.WriteLine("5-Halka Tatli");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlilar ----------");
            //}
            //Console.Read();
            #endregion

            #region switch case

            //Console.Write("ay'in sayisini giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("ocak");
            //        break;
            //    case 2:
            //        Console.Write("subat");
            //        break;
            //    case 3:
            //        Console.Write("mart");
            //        break;
            //    case 4:
            //        Console.Write("nisan");
            //        break;
            //    case 5:
            //        Console.Write("mayis");
            //        break;
            //    case 6:
            //        Console.Write("haziran");
            //        break;
            //    case 7:
            //        Console.Write("temmuz");
            //        break;
            //    case 8:
            //        Console.Write("agustos");
            //        break;
            //    case 9:
            //        Console.Write("eylul");
            //        break;
            //    case 10:
            //        Console.Write("ekim");
            //        break;
            //    case 11:
            //        Console.Write("kasim");
            //        break;
            //    case 12:
            //        Console.Write("aralik");
            //        break;
            //    default: Console.Write("hatali veri girisi"); break;
            //}
            //Console.Read();
            #endregion

            #region switch case hesap makinesi projesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("birinci sayiyi giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("yapmak istediginiz islemin sembolunu giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("hatali veri girdiniz");
            //        break;
            //}
            //Console.Read();
            #endregion
        }
    }
}
