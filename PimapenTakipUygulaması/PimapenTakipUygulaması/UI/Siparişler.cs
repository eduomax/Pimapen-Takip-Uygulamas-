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

    public partial class Siparişler : Form
    {
        public Siparişler()
        {
            InitializeComponent();
        }
      

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
  
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtMüsteriID)) return;
            if (!ErrorControl(comboÜrün)) return;
            if (!ErrorControl(numericAdet)) return;
            if (!ErrorControl(dateTarih)) return;
            DialogResult = DialogResult.OK;
            
        }
        private bool ErrorControl(Control C)
        {
            if (C is TextBox || C is ComboBox)
            {
                if (C.Text == "")
                {
                    errorProvider1.SetError(C, "Eksik Yerleri Doldurunuz!!!");
                    C.Focus();
                    return false;
                }

                else
                {
                    errorProvider1.SetError(C, "");
                    return true;
                }


            }
            if (C is NumericUpDown)
            {
                if (((NumericUpDown)C).Value == 0)
                {
                    errorProvider1.SetError(C, "Eksik Veye Hatalı bilgi Girdiniz!");
                    C.Focus(); return false;
                }
                else
                {
                    errorProvider1.SetError(C, "");
                    return true;
                }
            }
            return true;
        }
    }
}
