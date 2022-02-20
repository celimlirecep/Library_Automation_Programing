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
    public partial class formturler : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formturler()
        {
            InitializeComponent();
        }

        private void formturler_Load(object sender, EventArgs e)
        {
            turlergoster();
        }

        void turlergoster()
        {
             sorgucumlesi = "SELECT * FROM tblTurler";
            dgvturler.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            sorgucumlesi = $"USE Kutuphane_Projesi INSERT INTO tblTurler VALUES ('{txttur.Text}')";
            vr.islem(sorgucumlesi);
            turlergoster();
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvturler.CurrentRow.Cells[0].Value.ToString();
           
            sorgucumlesi = $"USE Kutuphane_Projesi UPDATE tblTurler " +
                $"SET TURAD='{txttur.Text}' WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            turlergoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvturler.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $" DELETE FROM tblTurler WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            turlergoster();
        }

        private void dgvturler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txttur.Text = dgvturler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttur.ResetText();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();
        }

        private void formturler_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
