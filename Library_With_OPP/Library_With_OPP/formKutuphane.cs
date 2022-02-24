using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_With_OPP
{
    public partial class formKutuphane : Form
    {
        string sorguCumlesi;
        veritabani vt = new veritabani();
        public formKutuphane()
        {
            InitializeComponent();
        }

      

        private void formKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimtarihi.Visible = false;
            doldur();
        }

        private void btnKitapTuruEkle_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.TurAd = txtKitapTuru.Text;
             sorguCumlesi = $"INSERT INTO tblTurler VALUES (@turAd)";
            vt.yeniKayitEkle(sorguCumlesi, yeniTur.TurAd);

        }

        private void btnYeniKitapekle_Click(object sender, EventArgs e)
        {
            Kitaplar yeniKitap = new Kitaplar();
            yeniKitap.ISBN = txtISBN.Text;
            yeniKitap.Ad = txtKitapAdi.Text;
            yeniKitap.SayfaSayisi = int.Parse( txtKitapSayfaSayisi.Text);
            yeniKitap.StokAdedi =int.Parse( txtKitapStok.Text);
            yeniKitap.TurID = int.Parse(cmbKitaplarKitapTuruID.Text);
            yeniKitap.YayineviID = int.Parse(cmbKitaplarYayıneviID.Text);
            yeniKitap.YazarID = int.Parse(cmbKitaplarYazarID.Text);
            sorguCumlesi = $"INSERT INTO tblKitaplar VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7) ";
           /* List<string> gonderilecek = new List<string>();
            gonderilecek.Add(yeniKitap.ISBN);
            gonderilecek.Add(yeniKitap.Ad);
            gonderilecek.Add();
            gonderilecek.Add();
            gonderilecek.Add();
            gonderilecek.Add();
            gonderilecek.Add();*/
            vt.yeniKitapEkle(sorguCumlesi, yeniKitap.ISBN, yeniKitap.Ad, yeniKitap.SayfaSayisi, yeniKitap.StokAdedi, yeniKitap.TurID, yeniKitap.YayineviID, yeniKitap.YazarID);

        }
        public void doldur()
        {
            sorguCumlesi = $"SELECT * FROM tblTurler";
            cmbKitaplarKitapTuruID.DataSource = vt.DataGoster(sorguCumlesi);
            cmbKitaplarKitapTuruID.DisplayMember = "TURAD";
            cmbKitaplarKitapTuruID.ValueMember = "ID";
            sorguCumlesi = $"SELECT * FROM tblYazarlar";
            cmbKitaplarYazarID.DataSource = vt.DataGoster(sorguCumlesi);
            cmbKitaplarYazarID.DisplayMember = "ADSOYAD";
            cmbKitaplarYazarID.ValueMember = "ID";
            sorguCumlesi = $"SELECT * FROM tblYayinevleri";
            cmbKitaplarYayıneviID.DataSource = vt.DataGoster(sorguCumlesi);
            cmbKitaplarYayıneviID.DisplayMember = "AD";
            cmbKitaplarYayıneviID.ValueMember = "ID";
            Uyeler uye = new Uyeler();
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Uyeler.CinsiyetTurleri));
            cmbUyeTipi.DataSource = Enum.GetValues(typeof(Uyeler.Uyeliktipleri));
            cmbEgitimDurumu.DataSource = Enum.GetValues(typeof(Uyeler.EgitimDurumlari));
            cmbCezaDurumu.DataSource = Enum.GetValues(typeof(Uyeler.CezaDurumları));
            cmbYazarCinsiyet.DataSource = Enum.GetValues(typeof(Uyeler.CinsiyetTurleri));

            sorguCumlesi = "SELECT * FROM tblTurler";
            cmbYazarKitapTuru.DataSource = vt.DataGoster(sorguCumlesi);
            cmbYazarKitapTuru.DisplayMember = "TURAD";
            cmbYazarKitapTuru.ValueMember = "ID";








        }


       

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            YayinEvleri yayinEvleri = new YayinEvleri();
            yayinEvleri.YayinEviAd = txtYayinEviAdi.Text;
            yayinEvleri.YayineviAdress = txtYayinEviAdresi.Text;
            yayinEvleri.Tel = txtYayinEviTelefonu.Text;

            List<string> gonder = new List<string>();
            gonder.Add(yayinEvleri.YayinEviAd);
            gonder.Add(yayinEvleri.YayineviAdress);
            gonder.Add(yayinEvleri.Tel);
            sorguCumlesi = "INSERT INTO tblYayinevleri VALUES (@P1,@P2,@P3)";
            vt.yeniYayineviEkle(sorguCumlesi, gonder);


        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         //   MessageBox.Show(cmbCinsiyet.SelectedValue.ToString()+cmbCinsiyet.SelectedIndex.ToString()+"dsgdsg");
            
         //   cmbCinsiyet.SelectedItem = Kisiler.CinsiyetTurleri.Kadın;
        }
    }
}
