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
    public partial class formyazarlar : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formyazarlar()
        {
            InitializeComponent();
        }

        private void formyazarlar_Load(object sender, EventArgs e)
        {
            yazalarigoster();

        }
        void yazalarigoster()
        {
            sorgucumlesi = "SELECT * FROM tblYazarlar";
            dgvyazarlar.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbcinsiyet.Text == "ERKEK" ? "E" : "K";
            sorgucumlesi = $"USE Kutuphane_Projesi INSERT INTO tblYazarlar VALUES ('{txtad.Text}','{txtsoyad.Text}','{cinsiyet}','{txtdogumtarihi.Text}','{txttel.Text}','{txtmail.Text}')";
            vr.islem(sorgucumlesi);
            yazalarigoster();
           
        }
        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvyazarlar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbcinsiyet.Text == "ERKEK" ? "E" : "K";
            sorgucumlesi = $"USE Kutuphane_Projesi UPDATE tblYazarlar " +
                $"SET YAZARAD='{txtad.Text}',YAZARSOYAD='{txtsoyad.Text}'," +
                $"YAZARCINSIYET='{cinsiyet}',YAZARDOGUMTARIHI='{txtdogumtarihi.Text}'," +
                $"YAZARTEL='{txttel.Text}',YAZARMAIL='{txtmail.Text}' WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            yazalarigoster();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvyazarlar.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $" DELETE FROM tblYazarlar WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            yazalarigoster();
        }




        private void dgvyazarlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dgvyazarlar.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dgvyazarlar.CurrentRow.Cells[2].Value.ToString();
            cmbcinsiyet.Text = dgvyazarlar.CurrentRow.Cells[3].Value.ToString() == "E" ? "ERKEK" : "KADIN";
            txtdogumtarihi.Text = dgvyazarlar.CurrentRow.Cells[4].Value.ToString();
            txttel.Text = dgvyazarlar.CurrentRow.Cells[5].Value.ToString();
            txtmail.Text = dgvyazarlar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtdogumtarihi.Clear();
            txtsoyad.Clear();
            txtmail.Clear();
            txttel.Clear();
            cmbcinsiyet.SelectedIndex = 0;
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();
        }

        private void formyazarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
