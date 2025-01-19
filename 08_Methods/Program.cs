using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar

            //()
            //geriye deger dondurmeyen metotlar
            //customer --> listele, ekle, sil, guncelle 
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yildiz");
            //    Console.WriteLine("hakan ozturk");
            //    Console.WriteLine("murat yucedag");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();


            //Console.Read();
            #endregion

            #region geriye deger dondurmeyen string parametreli metotlar

            //void Write(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Write("mehmet yildirim");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("musteri: " + name + " " + surName);
            //}
            //CustomerCard("emre", "yildiz");
            //CustomerCard("aysegul", "kaya");

            #endregion

            #region geriye deger dondurmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 5, 9);
            //Sum(33, 23, 44);
            //Sum(23, 6, 23);

            #endregion

            #region geriye deger donduren metotlar

            //string CustomerName()
            //{
            //    return"buse yildiz"l;
            //}
            //CustomerName();

            //string StudentsCard()
            //{
            //    string name = "ali";
            //    string surName = "kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentsCard());

            #endregion

            #region geriye deger donduren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "ulke: " + countryName + " baskent: " + capital + " bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("ulke adini giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("baskent adini giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("turkiye", "ankara", "kirmizi-beyaz"));


            #endregion

            #region geriye deger donduren int parametreli metotlar
            //int Sum(int n1, int n2)
            //{
            //    int result = n1 + n2;
            //    return result;
            //}
            //Console.WriteLine(Sum(44,23));
            //Console.WriteLine(Sum(123,643));
            //Console.WriteLine(Sum(61,643));
            //Console.WriteLine(Sum(154,321));
            //Console.WriteLine(Sum(322,265));
            //Console.WriteLine(Sum(42,432));

            #endregion

            #region ornek uygulama
            //benim yaptigim ornek
            //int ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    return result;
            //}
            //string studentNameSurname;
            //int e1, e2, e3;
            //Console.Write("ogrenci ad soyad giriniz: ");
            //studentNameSurname = Console.ReadLine();

            //Console.Write("birinci sinav sonucunu giriniz: ");
            //e1 = int.Parse(Console.ReadLine());

            //Console.Write("ikinci sinav sonucunu giriniz: ");
            //e2 = int.Parse(Console.ReadLine());

            //Console.Write("ucuncu sinav sonucunu giriniz: ");
            //e3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("ortalama: " + ExamResult(studentNameSurname, e1, e2, e3));

            //hocanin yaptigi ornek
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli ogrenci sinavi gecti " + "ortalama: " + result;
                }
                else
                {
                    return student + " isimli ogrenci sinavdan kaldi " + "ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali Yildiz", 45, 90, 67));
            Console.WriteLine(ExamResult("Mehmet Budak", 34, 25, 10));
            Console.WriteLine(ExamResult("Emre Durak", 44, 23, 100));
            Console.Read();
            #endregion
        }
    }
}
