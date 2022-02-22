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
    public partial class homepage : Form
    {
        veritabani vr = new veritabani();
        public homepage()
        {
            InitializeComponent();
        }

        private void btnkitaplar_Click(object sender, EventArgs e)
        {
            manager.formkitaplaraç();
            this.Hide();

        }

        private void btnuyeler_Click(object sender, EventArgs e)
        {
            formuyeler page = new formuyeler();
            page.Show();
            this.Hide();
        }

        private void btnyayinevleri_Click(object sender, EventArgs e)
        {
            formyayinevleri page = new formyayinevleri();
            page.Show();
            this.Hide();
        }

        private void btnoduncler_Click(object sender, EventArgs e)
        {
            formodunc page = new formodunc();
            page.Show();
            this.Hide();
        }

        private void btnyazarlar_Click(object sender, EventArgs e)
        {
            formyazarlar page = new formyazarlar();
            page.Show();
            this.Hide();
        }

        private void btnturler_Click(object sender, EventArgs e)
        {
            formturler page = new formturler();
            page.Show();
            this.Hide();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            manager.Anaformkapat();
        }

        private void homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
