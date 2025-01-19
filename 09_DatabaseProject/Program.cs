using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ado.net

            Console.WriteLine("***** C# Veri Tabanli Urun-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urunler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Cikis Yap");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Lutfen Getirmek Istediginiz Tablo Numarasini Giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HJCF1IL;Initial Catalog=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblcategory", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            conn.Close();


            Console.Read();
        }
    }
}
