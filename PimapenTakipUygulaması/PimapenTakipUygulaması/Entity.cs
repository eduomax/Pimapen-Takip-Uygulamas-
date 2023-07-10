using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimapenTakipUygulaması
{
    
        public class Müşteri
        {
            public Guid Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Adres { get; set; }
            public string Telefon { get; set; }

    }
        public class Siparişler
        {
            public Guid Id { get; set; }
            public string Musteri_id { get; set; }
            public string Urun_id { get; set; }
            public double Adet { get; set; }
            public string Tarih { get; set; }
        }
        public class Ürünler
        {
            public Guid Id { get; set; }
            public string Ad { get; set; }
            public string Acıklama { get; set; }
            public string Kategori { get; set; }
            public double Fiyat { get; set; }
            public string Stok { get; set; }
       



    }
        public class Ödeme
        {
            public Guid Id { get; set; }
            public Müşteri Müşteri { get; set; }
            public DateTime Tarih { get; set; }
            public double Tutar { get; set; }
            public string ÖdemeTürü { get; set; }
            public string AÇıklama { get; set; }
        }
        public class Satış
        {
            public Guid Id { get; set; }
           
            public DateTime Tarih { get; set; }
            public double Fiyat { get; set; }

        }


    }
