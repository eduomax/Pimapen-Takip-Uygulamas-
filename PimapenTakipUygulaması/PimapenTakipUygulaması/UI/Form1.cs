using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimapenTakipUygulaması.UI;
using PimapenTakipUygulaması.BL;

namespace PimapenTakipUygulaması
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MüşteriEkle müşteriEkle = new MüşteriEkle()
            {
                Text = "Müşteri Ekle",
                Müşteri = new Müşteri() { Id = Guid.NewGuid() },

            };
        tekrar:
            var sonuc = müşteriEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(müşteriEkle.Müşteri);
                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;
            }
        }

        private void btnBUL_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MüşteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
            DataSet ds2 = BLogic.ÜrünGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.MüşteriGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.ÜrünGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void BtnDüzenle(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];

            MüşteriEkle müşteriEkle = new MüşteriEkle()
            {
                Text = "Müşteri Düzenle",
                Güncelleme = true,
                Müşteri = new Müşteri()
                {
                    Id = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString(),
                },
            };
            var sonuc = müşteriEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(müşteriEkle.Müşteri);
                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[0];

            var Id = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin Mi ?", "Silmeyi Onayla", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(Id);
                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[0];

            Ürün ürünekle = new Ürün()
            {
                Text = "Ürün Düzenle",
                Güncelleme = true,
                Ürünler = new Ürünler()
                {
                    Id = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Acıklama = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = row.Cells[4].Value.ToString(),
                    Kategori = row.Cells[5].Value.ToString(),
                },
            };
            var sonuc = ürünekle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünGüncelle(ürünekle.Ürünler);
                if (b)
                {

                    row.Cells[1].Value = ürünekle.Ürünler.Ad;

                    row.Cells[2].Value = ürünekle.Ürünler.Acıklama;

                    row.Cells[3].Value = ürünekle.Ürünler.Stok;

                    row.Cells[4].Value = ürünekle.Ürünler.Fiyat;


                    row.Cells[5].Value = ürünekle.Ürünler.Kategori;


                }
            } 
        }
            

                private void toolStripButton6_Click(object sender, EventArgs e)
        {
                DataGridViewRow row = dataGridView2.Rows[0];
               
                  {

                var Id = row.Cells[0].Value.ToString();

                var sonuc = MessageBox.Show("Seçili Kayıt Silinsin Mi ?", "Silmeyi Onayla", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.ÜrünSil(Id);
                if (b)
                {

                    DataSet ds = BLogic.ÜrünGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Ürün ürünekle = new Ürün()
            {
                Text = "Ürün Ekle",
                Ürünler = new Ürünler() { Id = Guid.NewGuid() },

            };
        tekrar:
            var sonuc = ürünekle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜrünEkle(ürünekle.Ürünler);
                if (b)
                {

                    DataSet ds = BLogic.ÜrünGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Satış satış = new Satış()
            {
                Text "Satış Yap"
            };
            if(satış.ShowDialog()==DialogResult.OK)
        }
    }
}
       
            
       
 
   
   
    


    
