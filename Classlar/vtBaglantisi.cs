using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SicilNet.Classlar
{
    class vtBaglantisi
    {
        public SqlConnection Baglan()
        {
        //    string provider = "Data Source=TOPAL;Initial Catalog=TahaZiraat;Persist Security Info=True;User ID=sa;Password=147147"; //;Connection Timeout=120
            //string provider = System.Configuration.ConfigurationManager.ConnectionStrings["SicilNet.Properties.Settings.SicilBaglantiSatiri"].ConnectionString.ToString();
            //    string provider = "Data Source=" + SicilNet.Properties.Settings.Default.SunucuIp + ";Initial Catalog=" + SicilNet.Properties.Settings.Default.DatabaseName + ";Persist Security Info=True;User ID=" + SicilNet.Properties.Settings.Default.DatabaseSa + ";Password=" + SicilNet.Properties.Settings.Default.DatabasePass+ ";Connection Timeout=9000";

            string provider = SicilNet.Properties.Settings.Default.SicilBaglantiSatiri + ";Connection Timeout=30";
            SqlConnection bag = new SqlConnection(provider);
            try
            {
                bag.Open();
          
              //  bag.ConnectionTimeout = 5000;
                frm_AnaForm.erisimhatasi = false;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Sunucu bağlantısı kurulamadı");
                frm_AnaForm.erisimhatasi = true;
            }
            return bag;
           
        }
        public DataTable TabloOku(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, this.Baglan());
            //MessageBox.Show(sql);
            adapt.Fill(tb);
            return tb;
        }

        public DataRow SatirCek(string sql)
        {
            DataRow satir = TabloOku(sql).Rows[0];
            //MessageBox.Show(sql);
            return satir;
        }

        public Boolean Isle(string sql)
        {
            try
            {
                SqlCommand islem = new SqlCommand(sql, this.Baglan());
                islem.ExecuteNonQuery();
                islem.CommandTimeout = 900000;
                return true;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "KAYIT YAPILAMADI");
                return false;
            }
        }

        #region FATURA İÇİN
        public DataSet DataSetCek(string sql, string tablo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, this.Baglan());
            
            adapt.Fill(ds, tablo);

            return ds;
        }
        #endregion
        //public void Isle(string sql)
        //{
        //    SqlCommand islem = new SqlCommand(sql, this.Baglan());
        //    islem.ExecuteNonQuery();
        //}
    }
}
