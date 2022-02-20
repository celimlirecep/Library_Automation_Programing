using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Automation_programing
{
    class veritabani
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable dt;
        string baglantiadresi = @"Server=RECEP-CELIMLI\SQLEXPRESS;Database=Kutuphane_Projesi;User=sa;Pwd=123";
      //  string sorgucumlesi;


        public DataTable databaglan(String sorgucumlesi)
        {
            baglanti = new SqlConnection(baglantiadresi);
            adapter = new SqlDataAdapter(sorgucumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public string islem(string sorgucumlesi)
        {
            baglanti = new SqlConnection(baglantiadresi);
            komut = new SqlCommand(sorgucumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            return "İŞLEM BAŞARIYLA GERÇEKLEŞTİRİLDİ...";
        }












    }
}
