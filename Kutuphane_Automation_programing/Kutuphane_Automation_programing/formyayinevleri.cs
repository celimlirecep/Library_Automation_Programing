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
    public partial class formyayinevleri : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formyayinevleri()
        {
            InitializeComponent();
        }

        private void formyayinevleri_Load(object sender, EventArgs e)
        {
            yayinevleridoldur();
        }
        void yayinevleridoldur()
        {
            string sorgucumlesi = "SELECT * FROM tblYayinevleri";
            dgvyayinevleri.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            sorgucumlesi = $"USE Kutuphane_Projesi INSERT INTO tblYayinevleri VALUES ('{txtad.Text}','{txtadres.Text}','{txttel.Text}')";
            vr.islem(sorgucumlesi);
            yayinevleridoldur();
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {

            string ID = dgvyayinevleri.CurrentRow.Cells[0].Value.ToString();
           
            sorgucumlesi = $"USE Kutuphane_Projesi UPDATE tblYayinevleri " +
                $"SET YAYINEVIADI='{txtad.Text}',YAYINEVIADRESI='{txtadres.Text}'," +
                $"YAYINEVITELEFONNUMARASI='{txttel.Text}' WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            yayinevleridoldur();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvyayinevleri.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $" DELETE FROM tblYayinevleri WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            yayinevleridoldur();
        }

        private void dgvyayinevleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dgvyayinevleri.CurrentRow.Cells[1].Value.ToString();
            txtadres.Text = dgvyayinevleri.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dgvyayinevleri.CurrentRow.Cells[3].Value.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadres.Clear();
            txttel.Clear();

        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();
        }

        private void formyayinevleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
