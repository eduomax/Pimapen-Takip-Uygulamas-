using PimapenTakipUygulaması.DL;
using PimapenTakipUygulaması.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimapenTakipUygulaması.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Müşteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            {
                try
                {
                    DataSet ds = DataLayer.MüşteriGetir(filtre);
                    return ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu" + ex.Message);
                    return null;
                }
            }
        }

        internal static bool MüşteriGüncelle(Müşteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(String id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }
        internal static DataSet ÜrünGetir(string filtre)
        {
            {
                try
                {
                    DataSet ds = DataLayer.ÜrünGetir(filtre);
                    return ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu" + ex.Message);
                    return null;
                }
            }
        }
        internal static bool ÜrünGüncelle(Ürünler u)
        {
            try
            {
                int res = DataLayer.ÜrünGüncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÜrünSil(string Id)
        {
            try
            {
                int res = DataLayer.ÜrünSil(Id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÜrünEkle(Ürünler u)
        {
            try
            {
                int res = DataLayer.ÜrünEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }
    }
}       
  


