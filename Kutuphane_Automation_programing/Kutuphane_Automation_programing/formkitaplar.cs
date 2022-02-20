using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Automation_programing
{
    
    public partial class formkitaplar : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formkitaplar()
        {
            InitializeComponent();
        }

        private void formkitaplar_Load(object sender, EventArgs e)
        {
            kitaplarıgoster();
            turlerigoster();
            yazarlarigoster();
            yayinevlerinigoster();

        }
        void kitaplarıgoster()
        {
             sorgucumlesi = "SELECT dbo.tblKitaplar.ID, dbo.tblKitaplar.KITAPADI, " +
                "dbo.tblKitaplar.KITAPSAYFASAYISI, dbo.tblKitaplar.KITAPSTOKADEDI," +
                "dbo.tblTurler.TURAD, dbo.tblYazarlar.YAZARAD, dbo.tblYayinevleri.YAYINEVIADI" +
                " FROM   dbo.tblKitaplar INNER JOIN dbo.tblTurler" +
                   " ON dbo.tblKitaplar.TURID = dbo.tblTurler.ID INNER JOIN dbo.tblYayinevleri" +
                     " ON dbo.tblKitaplar.YAYINEVIID = dbo.tblYayinevleri.ID INNER JOIN dbo.tblYazarlar" +
                      " ON dbo.tblKitaplar.YAZARID = dbo.tblYazarlar.ID";
            dgvkitaplar.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string turadi = cmbtur.SelectedValue.ToString();
            string yazaradi = cmbyazar.SelectedValue.ToString();
            string yayineviadi = cmbyayinevi.SelectedValue.ToString();
            sorgucumlesi = $"INSERT INTO tblKitaplar VALUES " +
               $"('{txtkitapadi.Text}','{txtsayfasayisi.Text}','{txtstok.Text}','{turadi}','{yazaradi}','{yayineviadi}')";
            vr.islem(sorgucumlesi);
            kitaplarıgoster();
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvkitaplar.CurrentRow.Cells[0].Value.ToString();
            string turadi = cmbtur.SelectedValue.ToString();
            string yazaradi = cmbyazar.SelectedValue.ToString();
            string yayineviadi = cmbyayinevi.SelectedValue.ToString();
            sorgucumlesi = $"UPDATE tblKitaplar SET " +
                $"KITAPADI='{txtkitapadi.Text}'," +
                $"KITAPSAYFASAYISI='{txtsayfasayisi.Text}'," +
                $"KITAPSTOKADEDI='{txtstok.Text}'," +
                $"TURID='{turadi}'," +
                $"YAZARID='{yazaradi}'," +
                $"YAYINEVIID='{yayineviadi}'" +
                $"WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            kitaplarıgoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvkitaplar.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $"DELETE FROM tblKitaplar WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            kitaplarıgoster();
        }

        void turlerigoster()
        {
            sorgucumlesi = "SELECT * FROM tblTurler";
            cmbtur.DataSource= vr.databaglan(sorgucumlesi);
            cmbtur.DisplayMember = "TURAD";
            cmbtur.ValueMember = "ID";

        }
        void yazarlarigoster()
        {
            sorgucumlesi = "SELECT * FROM tblYazarlar";
            cmbyazar.DataSource = vr.databaglan(sorgucumlesi);
            cmbyazar.DisplayMember = "YAZARAD";
            cmbyazar.ValueMember = "ID";
        }
        void yayinevlerinigoster()
        {
            sorgucumlesi = "SELECT * FROM tblYayinevleri";
            cmbyayinevi.DataSource = vr.databaglan(sorgucumlesi);
            cmbyayinevi.DisplayMember = "YAYINEVIADI";
            cmbyayinevi.ValueMember = "ID";
        }

        private void dgvkitaplar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapadi.Text = dgvkitaplar.CurrentRow.Cells[1].Value.ToString();
            txtsayfasayisi.Text = dgvkitaplar.CurrentRow.Cells[2].Value.ToString();
            txtstok.Text = dgvkitaplar.CurrentRow.Cells[3].Value.ToString();
            cmbtur.Text= dgvkitaplar.CurrentRow.Cells[4].Value.ToString();
            cmbyazar.Text= dgvkitaplar.CurrentRow.Cells[5].Value.ToString();
            cmbyayinevi.Text= dgvkitaplar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkitapadi.ResetText();
            txtsayfasayisi.ResetText();
            txtstok.ResetText();
            cmbtur.SelectedIndex = 0;
            cmbyayinevi.SelectedIndex = 0;
            cmbyazar.SelectedIndex = 0;
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();

        }

        private void formkitaplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
