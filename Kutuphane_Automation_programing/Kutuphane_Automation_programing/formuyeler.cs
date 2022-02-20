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
    public partial class formuyeler : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formuyeler()
        {
            InitializeComponent();
        }

        private void formuyeler_Load(object sender, EventArgs e)
        {

            uyelerigoster();
        }
        void uyelerigoster()
        {
            string sorgucumlesi = "SELECT * FROM tblUyeler";
            dgvUyeler.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            sorgucumlesi = $"USE Kutuphane_Projesi INSERT INTO tblUyeler VALUES ('{txtad.Text}','{txtsoyad.Text}','{txttc.Text}','{txttelefon.Text}','{txtmail.Text}')";
            vr.islem(sorgucumlesi);
            uyelerigoster();
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
         
            sorgucumlesi = $"USE Kutuphane_Projesi UPDATE tblUyeler " +
                $"SET UYEADI='{txtad.Text}',UYESOYAD='{txtsoyad.Text}'," +
                $"UYETC='{txttc.Text}',UYETEL='{txttelefon.Text}'," +
                $"UYEMAIL='{txtmail.Text}' WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            uyelerigoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $" DELETE FROM tblUyeler WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            uyelerigoster();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.ResetText();
            txtmail.ResetText();
            txttc.ResetText();
            txttelefon.ResetText();
        }

        private void dgvUyeler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmail.Text = dgvUyeler.CurrentRow.Cells[5].Value.ToString();
            txtad.Text = dgvUyeler.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dgvUyeler.CurrentRow.Cells[2].Value.ToString();
            txttelefon.Text = dgvUyeler.CurrentRow.Cells[4].Value.ToString();
            txttc.Text = dgvUyeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();
        }

        private void formuyeler_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
