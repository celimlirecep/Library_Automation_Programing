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
    public partial class formodunc : Form
    {
        veritabani vr = new veritabani();
        string sorgucumlesi;
        public formodunc()
        {
            InitializeComponent();
        }

        private void formodunc_Load(object sender, EventArgs e)
        {
            oduncgoster();
            kitaplaridoldur();
            uyeleridoldur();
        }

        void oduncgoster()
        {
             sorgucumlesi = "SELECT dbo.tblOdunc.ID,dbo.tblUyeler.UYEADI+" "+ dbo.tblUyeler.UYESOYAD AS'AD SOYAD', "+
                "dbo.tblKitaplar.KITAPADI, dbo.tblOdunc.ODUNCVERILMETARIHI," +
                " dbo.tblOdunc.TESLIMEDILMESIGEREKENTARIH, dbo.tblOdunc.TESLIMTARIHI" +
                " FROM dbo.tblKitaplar INNER JOIN dbo.tblOdunc " +
                "ON dbo.tblKitaplar.ID = dbo.tblOdunc.KITAPID INNER JOIN dbo.tblUyeler " +
                "ON dbo.tblOdunc.UYEID = dbo.tblUyeler.ID";
            dgvodunc.DataSource = vr.databaglan(sorgucumlesi);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string uyeadi = cmbuyeismi.SelectedValue.ToString();
            string kitapadi = cmbkitapismi.SelectedValue.ToString();
            sorgucumlesi = $"USE Kutuphane_Projesi INSERT INTO tblOdunc VALUES ('{uyeadi}','{kitapadi}','{txtalinmatarihi.Text}','{txtsonteslimtarihi.Text}','{txtteslimtarihi.Text}')";
            vr.islem(sorgucumlesi);
           oduncgoster();
        }
        private void btnduzelt_Click(object sender, EventArgs e)
        {
            string ID = dgvodunc.CurrentRow.Cells[0].Value.ToString();
            string uyeadi = cmbuyeismi.SelectedValue.ToString();
            string kitapadi = cmbkitapismi.SelectedValue.ToString();
            sorgucumlesi = $"USE Kutuphane_Projesi UPDATE tblOdunc " +
                $"SET UYEID='{uyeadi}',KITAPID='{kitapadi}'," +
                $"ODUNCVERILMETARIHI='{txtalinmatarihi.Text}',TESLIMEDILMESIGEREKENTARIH='{txtsonteslimtarihi.Text}'," +
                $"TESLIMTARIHI='{txtteslimtarihi.Text}' WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            oduncgoster();

        }

        void kitaplaridoldur()
        {
            sorgucumlesi = "SELECT * FROM tblKitaplar";
            cmbkitapismi.DataSource= vr.databaglan(sorgucumlesi);
            cmbkitapismi.DisplayMember = "KITAPADI";
            cmbkitapismi.ValueMember = "ID";
        }

        void uyeleridoldur()
        {
            sorgucumlesi = "SELECT UYEADI+UYESOYAD AS 'AD SOYAD' FROM tblUyeler";
            cmbuyeismi.DataSource = vr.databaglan(sorgucumlesi);
            cmbuyeismi.DisplayMember = "AD SOYAD";//*****************UYE İSMİ TAM YAZILMAYA İZİN VERMİYOR
           // cmbuyeismi.ValueMember = "ID";
        }

        private void dgvodunc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbuyeismi.Text = dgvodunc.CurrentRow.Cells[1].Value.ToString();
            cmbkitapismi.Text = dgvodunc.CurrentRow.Cells[2].Value.ToString();
            txtalinmatarihi.Text = dgvodunc.CurrentRow.Cells[3].Value.ToString();
            txtsonteslimtarihi.Text = dgvodunc.CurrentRow.Cells[4].Value.ToString();
            txtteslimtarihi.Text = dgvodunc.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string ID = dgvodunc.CurrentRow.Cells[0].Value.ToString();
            sorgucumlesi = $" DELETE FROM tblOdunc WHERE ID='{ID}'";
            vr.islem(sorgucumlesi);
            oduncgoster();
        }

        private void txttemizle_Click(object sender, EventArgs e)
        {
            cmbkitapismi.SelectedIndex = 0;
            cmbuyeismi.SelectedIndex = 0;
            txtalinmatarihi.ResetText();
            txtsonteslimtarihi.ResetText();
            txtteslimtarihi.ResetText();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            homepage HP = new homepage();
            HP.Show();
            this.Hide();
        }

        private void formodunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            btncik.PerformClick();
        }
    }
}
