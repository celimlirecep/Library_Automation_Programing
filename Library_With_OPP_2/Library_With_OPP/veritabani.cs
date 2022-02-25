using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_With_OPP
{
    class veritabani
    {
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=SlibraryAutomationPrograming;User=sa;Pwd=123";

        public veritabani()
        {
            baglanti = Olustur();
            baglantiac();
        }
        SqlConnection baglanti;
        public string TableName { get; set; }



       
        string sorgucumlesi;
        SqlDataAdapter adapter;


         SqlConnection Olustur()
        {
            baglanti = new SqlConnection(baglantiadresi);
         
            return baglanti;
        }

        void baglantiac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                
            }
        }

         void baglantikes()
        {
            if (baglanti.State==ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        public DataTable dt;
        //public DataTable Dt { get; set; }//*****************************************nesne property
      /// <summary>
      /// TABLOYA YAZDIRMA İŞLEMİ YAPAR
      /// </summary>
        public void islem()
        {
            sorgucumlesi = $" SELECT * FROM {TableName}";
            adapter = new SqlDataAdapter(sorgucumlesi, baglanti);
             dt = new DataTable();
            adapter.Fill(dt);
        }
        /// <summary>
        ///VERİLEN ID YE GÖRE KAYIT SİLME İŞLEMİ İÇİN KULLANILIR AMA GERÇEKTE SİLİNMEZ
        ///İLGİLİ KAYDIN İPTAL KOLUNA TRUE YAZAR
        /// </summary>
        /// <param name="ID"></param>
        public void islem(int ID)
        {
          
            sorgucumlesi =$"UPDATE {TableName} SET IPTAL=0 WHERE ID={ID}";
            SqlCommand komut = new SqlCommand(sorgucumlesi,baglanti);
            baglantiac();
            komut.ExecuteNonQuery();
            baglantikes();

        }

        public void islem(Odunc yeniodunc)
        {
            sorgucumlesi = $"INSERT INTO {TableName} (UYEID,KITAPISBN,VERILISTARIHI,IPTAL) VALUES " +
                $"(@UYEID,@KITAPISBN,@VERILISTARIHI,@IPTAL)";
           SqlCommand komut = new SqlCommand(sorgucumlesi,baglanti);
            komut.Parameters.AddWithValue("UYEID", yeniodunc.UyeID);
            komut.Parameters.AddWithValue("@KITAPISBN", yeniodunc.KitapISBN);
            komut.Parameters.AddWithValue("@VERILISTARIHI", yeniodunc.VerilisTarihi.ToString("yyyy-MM-dd"));//****************
            komut.Parameters.AddWithValue("@IPTAL", yeniodunc.İptal);
            baglantiac();
            komut.ExecuteNonQuery();
            baglantikes();


        }
        











    }
}
