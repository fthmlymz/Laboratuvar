using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MikroAnaliz.VeritabaniIslemler
{
    class SpListesiKaydetGuncelle
    {
        SqlConnection mySqlConnection = new SqlConnection(Properties.Settings.Default.SicilBaglantiSatiri);

       public void AnalizBilgileriEkle()
        {
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText =
              "CREATE TABLE MyEmployee (" +
              "  ID int IDENTITY(1,1) CONSTRAINT PK_Persons PRIMARY KEY," +
              "  FirstName nvarchar(15) NOT NULL," +
              "  LastName nvarchar(15) NOT NULL," +
              "  DateOfBirth datetime" +
              ")";

            mySqlConnection.Open();


            MessageBox.Show("Creating MyEmployee table");
            int result = mySqlCommand.ExecuteNonQuery();

            MessageBox.Show("mySqlCommand.ExecuteNonQuery() = " + result);

            mySqlCommand.CommandText =
              "ALTER TABLE MyEmployee " +
              "ADD EmployerID nchar(5) CONSTRAINT FK_Persons_Customers " +
              "REFERENCES Employee(ID)";

            MessageBox.Show("Altering MyEmployee table");

            result = mySqlCommand.ExecuteNonQuery();

            MessageBox.Show("mySqlCommand.ExecuteNonQuery() = " + result);

            mySqlCommand.CommandText = "DROP TABLE MyEmployee";

            //Console.WriteLine("Dropping MyEmployee table");
            result = mySqlCommand.ExecuteNonQuery();
            //Console.WriteLine("mySqlCommand.ExecuteNonQuery() = " + result);

            mySqlConnection.Close();
        }







    }
}
