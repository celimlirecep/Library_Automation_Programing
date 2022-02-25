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
        public veritabani()//constructer method
        {

        }
        public veritabani(string tabloAD, params string[] sutunlar)// bu overlood kayıt listeleme yapıcak
        {
            // join komudu öncesinde denedik

            /* foreach (var siradakisutunadi in sutunlar)
             {
                 istenilensutunlar += (siradakisutunadi+",");
             }
             istenilensutunlar = istenilensutunlar.Substring(0, istenilensutunlar.Length - 1);*///*************************************
            string istenilensutunlar = string.Join(",", sutunlar);// join ile stringe string ifadeleri atadık, aralarına virgül koyarak
            sorgucumlesi = $"SELECT {istenilensutunlar} FROM {tabloAD}";
            DataGoster(sorgucumlesi);
        

          }

        











        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=SlibraryAutomationPrograming;User=sa;Pwd=123";
        string sqlkomutlari;
        string sorgucumlesi;
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

         DataTable DataGoster(string sorgucumlesi)
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
        public string islem(string sqlkomutlari)
        {
            komut = new SqlCommand(sqlkomutlari, baglan());
            komut.ExecuteNonQuery();
            baglantikes();
            return "Yapılan İslem Basarili...";
        }

        /*   public string yeniKayitEkle(string sqlkomutlari)
           {

               komut = new SqlCommand(sqlkomutlari, baglan());//**********islem komudu ile birlestirildi
               komut.ExecuteNonQuery();
               baglantikes();
               return  " Yeni İsim Başarıyla Kaydedildi...";
           }*/



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
