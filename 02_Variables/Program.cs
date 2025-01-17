using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double
            //double number;
            //number = 5.4;
            //Console.WriteLine(number);
            //Console.Read();

            //ex1
            //Console.WriteLine("***** Manav Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, strawberryPrice, watermelonPrice, orangePrice;
            //applePrice = 9.90;
            //strawberryPrice = 12.90;
            //watermelonPrice = 30;
            //orangePrice = 17.50;

            //Console.WriteLine("----- Apple Price: " + applePrice + "TL / KG");
            //Console.WriteLine("----- Strawberry Price: " + strawberryPrice + "TL / KG");
            //Console.WriteLine("----- Watermelon Price: " + watermelonPrice + "TL / KG");
            //Console.WriteLine("----- Orange Price: " + orangePrice + "TL / KG");

            //double appleKG, strawberryKG, watermelonKG, orangeKG;
            //appleKG = 1.245;
            //strawberryKG = 2.650;
            //watermelonKG = 1.750;
            //orangeKG = 1.650;

            //double appleTotalPrice, strawberryTotalPrice, watermelonTotalPrice, orangeTotalPrice;
            //appleTotalPrice = applePrice * appleKG;
            //strawberryTotalPrice = strawberryPrice * strawberryKG;
            //watermelonTotalPrice = watermelonPrice * watermelonKG;
            //orangeTotalPrice = orangePrice * orangeKG;

            //Console.WriteLine();
            //Console.WriteLine("*****Receipt*****");
            //Console.WriteLine();
            //Console.WriteLine("----- Apple Price: " + applePrice + "TL");
            //Console.WriteLine("----- Apple Weight: " + appleKG + "KG");
            //Console.WriteLine("----- Apple Total Price: " + appleTotalPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("----- Strawberry Price: " + strawberryPrice + "TL");
            //Console.WriteLine("----- Strawberry Weight: " + strawberryKG + "KG");
            //Console.WriteLine("----- Strawberry Total Price: " + strawberryTotalPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("----- Watermelon Price: " + watermelonPrice + "TL");
            //Console.WriteLine("----- Watermelon Weight: " + watermelonKG + "KG");
            //Console.WriteLine("----- Watermelon Total Price: " + watermelonTotalPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("----- Orange Price: " + orangePrice + "TL");
            //Console.WriteLine("----- Orange Weight: " + orangeKG + "KG");
            //Console.WriteLine("----- Orange Total Price: " + orangeTotalPrice + "TL");

            //double shoppingTotalPrice;
            //shoppingTotalPrice = appleTotalPrice + strawberryTotalPrice + watermelonTotalPrice + orangeTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Total Price: " + shoppingTotalPrice + "TL");

            //Console.Read();
            #endregion

            #region char
            //char character;
            //character = 'a';
            //Console.WriteLine(character);
            //Console.Read();
            #endregion

            #region klavyeden veri girisleri string degiskenler
            //Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdNumber;
            //Console.Write("Yolcu Ad: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyad: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Sehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Bolge: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yas: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu T.C. No: ");
            //passengerIdNumber = Console.ReadLine();

            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine("Yolcu Ad Soyad: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu Sehir: " + passengerDistrict + " / " + passengerCity);
            //Console.WriteLine("Yolcu Yas: " + passengerAge);
            //Console.WriteLine("Yolcu T.C. No: " + passengerIdNumber);
            //Console.Read();
            #endregion

            #region klavyeden veri girisleri int degiskenler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 4000;
            //computerPrice = 50000;
            //chairPrice = 8000;
            //tvPrice = 35000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz tv sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalprice = shoesCount * shoePrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam odemeniz gereken tutar: " + totalprice);
            //Console.Read();
            #endregion

            #region klavyeden veri girisleri double degiskenler
            //double exam1, exam2, exam3, result;
            //Console.Write("Lutfen 1. Sinav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. Sinav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 3. Sinav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamaniz: " + result);
            //Console.Read();
            #endregion

            #region klavyeden veri girisleri char degiskenler
            //char gender;
            //Console.Write("Lutfen Cinsiyet Giriniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Sectiginiz cinsiyet: " + gender);
            //Console.Read();
            #endregion
        }
    }
}
