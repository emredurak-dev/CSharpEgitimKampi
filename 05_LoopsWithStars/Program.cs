using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta on tane yildiz olusturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //Console.Read();
            #endregion

            #region yan yana on tane yildiz olusturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.Read();
            #endregion

            #region alt alta on tane yildiz ve her satirda on tane yildiz olusturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            //Console.Read();
            #endregion

            #region yildizlarla dik ucgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion

            #region yildizlarla ters dik ucgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion

            #region dik ucgen ve ters dik ucgen beraber
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 9; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion

            #region baklava dilimi
            //int n = 5;
            //ust kisim
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //alt kisim
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();

            #endregion

            #region piramit
            //int n = 5;
            //for (int i = 0; i <= n; i++)
            //{
            //    //bosluklar icin
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yildizlar icin
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion

            #region ters piramit
            //int n = 5;
            //for (int i = n; i > 0; i--)
            //{
            //    //bosluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yildizlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion
        }
    }
}
