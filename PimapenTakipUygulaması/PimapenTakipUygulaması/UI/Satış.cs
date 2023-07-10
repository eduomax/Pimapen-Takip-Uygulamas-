using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PimapenTakipUygulaması.UI
{
    public partial class Satış : Form
    {
        public Satış()
        {
            InitializeComponent();
        }
      
        public Müşteri Müşteri { get; set; }
        public Ürünler Ürünler { get; set; }    

        private void Satış_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(numericFiyat.Value ==0)
            {
                errorProvider1.SetError(numericFiyat, "Lütfen Geçerli Bir tutar Giriniz.");
                numericFiyat.Focus();
                    return;
            }
            else
            {
                errorProvider1.SetError(numericFiyat, "");

            }
            DialogResult= DialogResult.OK;
        }
    }
}
