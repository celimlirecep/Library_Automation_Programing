using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_With_OPP
{
    class Kutuphane
    {

    }
    //******************************************************************tblTurler tablosu için
    public class Tur
    {
        private int id;//kendi yazıcak sadece okumak için kullanıcaz

        public int ID
        {
            get { return id; }
        }

        private string turAd;

        public string TurAd
        {
            get { return turAd; }
            set { turAd = value.ToUpper(); }
        }


    }
    //***************************************************************** tblYayinEvleri Tablosuİçin
    public class Yayinevİ
    {
        private int id;

        public int ID
        {
            get { return id; }
        }

        public string YayinEviAd { get; set; }
        public string YayineviAdress { get; set; }
        public string Tel { get; set; }

    }

    //************************************************ İNSAN ÖZELLİKLERİ OLANLARI BİR GRUPTA TOPLADIK
    public class Kisi
    {
        private int id;

        public int ID
        {
            get { return id; }
        }

        public string AdSoyad { get; set; }

        public enum CinsiyetTurleri
        {
            Erkek,Kadın,Melez
        }

        public CinsiyetTurleri Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

    }

    //***************************************************************** tblUyeler tablosu
    public class Uye : Kisi//kişilerdeki ortak özellikleri alır
    {
        public Uye()
        {
            CezaDurumu = false;//haberimiz olsun diye yazdık zaten false olrak geliyo
        }
        public enum Uyeliktipleri
        {
            Standart, Elit
        }
        public enum EgitimDurumlari
        {
            IlkokulMezunu, OrtaokulMezunu, LiseMezunu, UniversiteMezunu, Ogrenci
        }
        public DateTime UyelikTarihi { get; set; }
        public Uyeliktipleri Uyeliktipi { get; set; }
        public string Meslek { get; set; }
        public string TcNo { get; set; }
        public EgitimDurumlari EgitimDurumu { get; set; }
        public enum CezaDurumları
        {
            Var,Yok
        }
        public bool CezaDurumu { get; set; }// bool default olarak false gelir 

    }

    //*****************************************************************tblYazarlar tablosu oluşturuldu
    public class Yazar : Kisi
    {
        public int TurID { get; set; }//yazarın en çok on plana çıktıgı tür bilgisi


    }


    //*****************************************************************tblKitaplar
    public class Kitap
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public int SayfaSayisi { get; set; }
        public int StokAdedi { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }


    }

    //***************************************************************** tblOduncler Tablosu

    public class Odunc
    {
        private int id;

        public int ID
        {
            get { return id; }
        }
        public int UyeID { get; set; }//FOREIGN KEY
        public string KitapISBN { get; set; }//FK
        public DateTime VerilisTarihi { get; set; }// Son teslim tarihi eklenmeyecek o sayısal 
                                                   //olarak 10 gün sonra teslim et şeklinde olucak
        public DateTime TeslimTarihi { get; set; }
        public bool İptal { get; set; }//kitabın yanlış girilme durumuna göre 
                                       //verilerin kontrolü sağlanıcak (default olarak false)
                                       //İptal edilirse true olarak çeviricez(silinirse true)



    }
}
