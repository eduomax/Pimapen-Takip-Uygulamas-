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
    public partial class Ürün : Form
    {
       
        public Ürün()
        {
            InitializeComponent();
        }
       

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Ürünler Ürünler { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtDetay)) return;
            if (!ErrorControl(comboKategori)) return;
            if (!ErrorControl(numericFiyat)) return;
            if (!ErrorControl(numericStok)) return;
          


            Ürünler.Ad = txtAd.Text;
            Ürünler.Acıklama = txtDetay.Text;
            Ürünler.Stok = numericStok.Text;
            Ürünler.Kategori = comboKategori.Text;
            Ürünler.Fiyat =(double) numericFiyat.Value;
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

        private void Ürün_Load(object sender, EventArgs e)
        {
            txtID.Text = Ürünler.Id.ToString();
            if (Güncelleme)
            {
                txtAd.Text = Ürünler.Ad;
                numericFiyat.Value = (decimal)Ürünler.Fiyat;
                txtDetay.Text = Ürünler.Acıklama;
                comboKategori.Text = Ürünler.Kategori;
                numericStok.Text = Ürünler.Stok;
            }
        }
    }
}


