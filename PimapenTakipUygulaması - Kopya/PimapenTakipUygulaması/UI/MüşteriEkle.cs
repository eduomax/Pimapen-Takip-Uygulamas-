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
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Müşteri Müşteri { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAD)) return;
            if (!ErrorControl(txtAdres)) return;
            if (!ErrorControl(maskedTelefon)) return;
            if (!ErrorControl(txtSoyad)) return;

            Müşteri.Ad = txtAD.Text;
            Müşteri.Adres = txtAdres.Text;
            Müşteri.Telefon = maskedTelefon.Text;
            Müşteri.Soyad = txtSoyad.Text;


            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control C )
        {
            if(C is TextBox)
            {
                if(C.Text =="")
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
            if (C is MaskedTextBox)
            {
                if(!((MaskedTextBox)C).MaskFull) 
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

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {
            txtID.Text = Müşteri.Id.ToString();
            if (Güncelleme)
            {
                txtAD.Text = Müşteri.Ad;
                txtAdres.Text  = Müşteri.Adres;
                maskedTelefon.Text =  Müşteri.Telefon;
                txtSoyad.Text = Müşteri.Soyad;
            }
          
        }
    }
}
