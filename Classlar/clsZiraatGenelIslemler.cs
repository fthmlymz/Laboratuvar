using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SicilNet.Classlar
{
    class clsZiraatGenelIslemler
    {
        SicilNet.Classlar.vtBaglantisi Dbase = new vtBaglantisi();
        public DataRow KurumAyarAc(string OdaNumarasi)
        {
            string Sql = "SELECT TOP 1 * FROM T_KurumAyar WHERE KURUM_KRMODANO=" + OdaNumarasi;
            return Dbase.SatirCek(Sql);
        }
        public DataRow KurumAidatAl(string OdaNumarasi)
        {
            string Sql = "SELECT TOP 1 * FROM T_AidatCinsleri WHERE AC_ODANO=" + OdaNumarasi;
            return Dbase.SatirCek(Sql);
        }

        public DataRow MuvAdiSoyadiBul(string TcNumarasi)
        {
            string Sql = "SELECT TOP 1 * FROM Muv WHERE KimNo=" + TcNumarasi;
            return Dbase.SatirCek(Sql);
        }
    }
}
