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
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=SlibraryAutomationPrograming;User=sa;Pwd=123";
        string sqlkomutlari;
        DataTable dt;
        public SqlConnection baglan()
        {
            baglanti = new SqlConnection(baglantiadresi);
          
            if (baglanti.State == ConnectionState.Closed)//*****************************
            {
                baglanti.Open();
            }
            return baglanti;
        }

        public void baglantikes()
        {
            if (baglanti.State == ConnectionState.Open)//*****************************
            {
                baglanti.Close();
            }
        }

        public DataTable DataGoster(string sorgucumlesi)
        {
            adapter = new SqlDataAdapter(sorgucumlesi, baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool kayitkontrol(params string[] e)//********************************************************************
        {
            bool donus = true;
            foreach (var item in e)
            {

                if (item == "")
                {
                    donus = false;
                    break;
                }
            }
            return donus;
        }
        public string islem(string sqlkomutlari, string turAd)
        {
           
            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);
            komut.ExecuteNonQuery();
            baglantikes();
            return "Yapılan İslem Basarili...";
        }
       

           public string yeniKayitEkle(string sqlkomutlari,string TurAd)
           {

               komut = new SqlCommand(sqlkomutlari, baglan());
            komut.Parameters.AddWithValue("@turAd", TurAd);//**********islem komudu ile birlestirildi
               komut.ExecuteNonQuery();
               baglantikes();
               return  " Yeni İsim Başarıyla Kaydedildi...";
           }

        //
        public string yeniKitapEkle(string sqlkomutlari, string p1, String p2, int p3, int p4, int p5, int p6, int p7)
        {

            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.Parameters.AddWithValue("@P1", p1);
            komut.Parameters.AddWithValue("@P2", p2);
            komut.Parameters.AddWithValue("@P3", p3);
            komut.Parameters.AddWithValue("@P4", p4);
            komut.Parameters.AddWithValue("@P5", p5);
            komut.Parameters.AddWithValue("@P6", p6);
            komut.Parameters.AddWithValue("@P7", p7);
            komut.ExecuteNonQuery();
            baglantikes();
            return " Yeni İsim Başarıyla Kaydedildi...";
        }

        public void yeniYayineviEkle(string sorgucumlesi,List<string> getir)
        {
            komut = new SqlCommand(sorgucumlesi,baglan());
            short i = 1;
            foreach (var item in getir)
            {
                komut.Parameters.Add($"@P{i}",item);
                i++;
            }
           
            komut.ExecuteNonQuery();
            baglantikes();


        }



        /*   public void duzenle(string sqlkomutlari)
           {

               komut = new SqlCommand(sqlkomutlari, baglan());// ***** islem komudu ile birleştirildi
               komut.ExecuteNonQuery();
               baglantikes();

           }
   */
        /*   public void dataSil(string sqlkomutlari)
           {

               komut = new SqlCommand(sqlkomutlari, baglan());//******* islem komudu ile birlestirildi
               komut.ExecuteNonQuery();
               baglantikes();
           }*/


















    }
}
