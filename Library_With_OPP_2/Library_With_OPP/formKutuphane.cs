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
        veritabani vt = new veritabani();
        
        public formKutuphane()
        {
            InitializeComponent();
        }
        

        
        private void formKutuphane_Load(object sender, EventArgs e)
        {
            //******* ödünç listesini günceşller
            vt.TableName = "tblOduncler";
            vt.islem();
            dgvOduncIslemleri.DataSource = vt.dt;
            //**** üye listesini günceller
            vt.TableName = "tblUyeler";
            vt.islem();
            dgvUye.DataSource = vt.dt;
            for (int i = 0; i < dgvUye.Columns.Count; i++)
            {
               
                dgvUye.Columns[i].Visible = false;

            }
            dgvUye.Columns[1].Visible = true;


           
            //**** kitap listesini günceller
            vt.TableName = "tblKitaplar";
            vt.islem();
            dgvKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvKitap.Columns.Count; i++)
            {

                dgvKitap.Columns[i].Visible = false;

            }
            dgvKitap.Columns[1].Visible = true;


        }

        private void btnOduncİptalEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOduncIslemleri.CurrentRow.Cells[0].Value.ToString());
            vt.TableName = "tblOduncler";
            vt.islem(id);
       


        }

        void oduncrefresh()
        {
            vt.TableName = "tblOduncler";
            vt.islem();
            dgvOduncIslemleri.DataSource = vt.dt;
        }
        private void btnOduncTeslimVer_Click(object sender, EventArgs e)
        {
           
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = int.Parse(dgvUye.SelectedRows[0].Cells[0].Value.ToString());//**************
            yeniOdunc.KitapISBN= dgvKitap.SelectedRows[0].Cells[0].Value.ToString();//*** seçili birden fazla satır kullanmka yerine ilk satırı kullanmka için
            yeniOdunc.VerilisTarihi = dtpVerilisTarihi.Value;
            yeniOdunc.İptal = false;
            vt.TableName = "tblOduncler";
            vt.islem(yeniOdunc);
            oduncrefresh();
        }
        void doldur()
        {
            int aranan = Convert.ToInt32(dgvOduncIslemleri.SelectedRows[0].Cells[1].Value.ToString());
            foreach (DataGridViewRow satir in dgvUye.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString())==aranan)
                {
                    satir.Selected = true;
                    break;
                }


            }
        }
       

        private void dgvOduncIslemleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                doldur();
            }
            catch (Exception)
            {

             //   throw;
            }
           
          
        }
    }
}
