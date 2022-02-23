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
        public formKutuphane()
        {
            InitializeComponent();
        }

      

        private void formKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimtarihi.Visible = false;
        }

       
    }
}
