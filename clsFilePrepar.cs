using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace MikroAnaliz
{
    class clsFilePrepar
    {
        public DataTable Rep_DgdAraziBelgesi(DataTable arz, DataTable urt)
        {
            Sicdata scVeri = new Sicdata();
            //DataTable arzi;
            //  arzi = arz.Clone;
            //Sicdata.ArazilerRow arzr;
            for (int i = 0; i < arz.Rows.Count; i++)
            {
                //endata.Araziler.AddArazilerRow((DataRow) arz.Rows);
                //arzr=endata.Araziler.NewArazilerRow();
            }
            //endata.Araziler=arz.Clone();
            return arz;
        }

    }
}
