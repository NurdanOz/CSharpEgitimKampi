using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");

            #region KATEGORİ EKLEME İŞLEMİ
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryname = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=FATIH\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand(" insert into TBLCATEGORY(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryname);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi!");
            #endregion

            #region ÜRÜNÜ EKLEME İŞLEMİ
            // String productname;

            // decimal productprice;
            //// bool productstatus;

            // Console.Write("ÜRÜN ADI: ");
            // productname = Console.ReadLine();
            // Console.Write("ÜRÜN FİYATI: ");
            // productprice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=FATIH\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into TBLPRODUCT (ProductName,ProductPrice,ProductStatu) values (@p1,@p2,@p3)", connection);
            // command.Parameters.AddWithValue("@p1", productname);
            // command.Parameters.AddWithValue("@p2", productprice);
            // command.Parameters.AddWithValue("@p3", true);
            // command.ExecuteNonQuery();
            // connection.Close();
            // Console.Write("ÜRÜN EKLEMESİ BAŞARILI!");

            #endregion

            #region ÜRÜN LİSTELEME İŞLEMİ


            //SqlConnection connection = new SqlConnection("Data Source=FATIH\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TBLPRODUCT", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();


            #endregion

            #region ÜRÜN SİLME İŞLEMİ

            //Console.Write("Silenecek ürün ID: ");
            //int productIdd = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=FATIH\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM TBLPRODUCT WHERE ProductId=@p1", connection);
            //command.Parameters.AddWithValue("@p1",productIdd);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı");


            #endregion

            #region ÜRÜN GÜNCELLEME İŞLEMİ 

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productIdd =int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productNamee = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPricee = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=FATIH\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE TBLPRODUCT SET ProductName=@p1,ProductPrice=@p2 where ProductId=@p3", connection);
            //command.Parameters.AddWithValue("@p1", productNamee);
            //command.Parameters.AddWithValue("@p2", productPricee);
            //command.Parameters.AddWithValue("@p3", productIdd);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı!");



            #endregion


            Console.Read();

        }
    }
}
