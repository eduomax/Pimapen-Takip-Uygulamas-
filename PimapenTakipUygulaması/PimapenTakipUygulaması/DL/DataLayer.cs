using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimapenTakipUygulaması.BL;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace PimapenTakipUygulaması.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
          new MySqlConnectionStringBuilder()
          {
              Server = "127.0.0.1",
              Database = "pimapen_takip_uygulamasi",
              UserID = "root",
              Password = "270231",
          }.ConnectionString
          );

        public static int MüşteriEkle(Müşteri m)
        {
             
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("pimapen_MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.Id);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);
                
                int res = komut.ExecuteNonQuery();
                return res;
                
            }
            catch ( Exception ex)
            {
                throw ex;
            }
            finally
            { 
                if( conn.State != System.Data.ConnectionState.Closed)
                conn.Close(); 
            }

         
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                    {
                        komut = new MySqlCommand("pimapen_MusterilerHepsi", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                        

                    }
                else
                {
                        komut = new MySqlCommand("pimapen_MusteriGetir", conn);
                        komut.CommandType = System.Data.CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);
                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriGüncelle(Müşteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
               

                MySqlCommand komut = new MySqlCommand("pimapen_MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.Id);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();


                MySqlCommand komut = new MySqlCommand("pimapen_MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
               
                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        public static int ÜrünEkle(Ürünler u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("pimapen_UrunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.Id);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@detay", u.Acıklama);
                komut.Parameters.AddWithValue("@stok", u.Stok);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("pimapen_UrunlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;


                }
                else
                {
                    komut = new MySqlCommand("pimapen_UrunBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);
                return dataset;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int ÜrünGüncelle(Ürünler u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();


                MySqlCommand komut = new MySqlCommand("pimapen_UrunGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.Id);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@detay", u.Acıklama);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);



                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int ÜrünSil(string Id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();


                MySqlCommand komut = new MySqlCommand("pimapen_UrunSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", Id);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
    }
    
    

