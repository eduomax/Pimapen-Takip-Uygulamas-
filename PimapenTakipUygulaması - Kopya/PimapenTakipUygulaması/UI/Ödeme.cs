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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (numericTutar.Value == 0)
            {
                errorProvider1.SetError(numericTutar, "Lütfen Geçerli Bir tutar Giriniz.");
                numericTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(numericTutar, "");
                
            }
            if (comboÖdemeTürü.SelectedItem == null)
            {
                    errorProvider1.SetError(comboÖdemeTürü, "Eksik Veye Hatalı bilgi Girdiniz!");
                    comboÖdemeTürü.Focus();
                return ;
                }
                else
                {
                    errorProvider1.SetError(comboÖdemeTürü, "");
                 
                }
            if (txtAçıklama.Text == "")
            {
                errorProvider1.SetError(txtAçıklama, "Eksik Veye Hatalı bilgi Girdiniz!");
                txtAçıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAçıklama, "");

            }

            DialogResult = DialogResult.OK;
        }
    }
}
