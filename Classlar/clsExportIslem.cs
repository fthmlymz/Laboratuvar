using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using System.IO;

namespace MikroAnaliz.Classlar
{
    class clsExportIslem
    {
        SaveFileDialog Save = new SaveFileDialog();
        //MikroAnaliz.Classlar.Mesaj msg = new Mesaj();

        public void ExcelBorcluListesi(string RaporAdi, DevExpress.XtraGrid.GridControl List)
        {
            //Save.FileName = RaporAdi + ".xls";
            //if (Save.ShowDialog() == DialogResult.OK)
            //{
            //    List.ExportToXls(Save.FileName);
            //    if (msg.Sor("Kayıt yapılan excel dosyasını açmak istiyor musunuz ?"))
            //    {
            //        Process.Start(Save.FileName);
            //    }
            //}
        }

        //excel 2003 kaydet
        public void Excel_2003(string ReportName, DevExpress.XtraGrid.GridControl List)
        {
           // string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string appFolder = AppDomain.CurrentDomain.BaseDirectory;
            Save.FileName =  ReportName + ".xls";
            List.ExportToXls(appFolder + Save.FileName);
     
            //if (Save.ShowDialog() == DialogResult.OK)
            //{
            //    List.ExportToXls(Save.FileName);
            //    //if (msg.Sor("Dosyayı açmak istiyor musunuz ?"))
            //    //{
            //        //Process.Start(Save.FileName);
            //    //}
            //}
                MessageBox.Show("Sistem hazırlığı yapıldı, muhasebe programına gönderebilirsiniz","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
            
            /*
             * 
             * 
             *  MessageBox.Show("Sistem hazırlığı yapıldı, muhasebe programına gönderebilirsiniz","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Save.ShowDialog() == DialogResult.OK)
            {
                List.ExportToXls(Save.FileName);
                if (msg.Sor("Dosyayı açmak istiyor musunuz ?"))
                {
                    Process.Start(Save.FileName);
                }
            }
             * 
             * 
             * 
             * */
        }

    }
}
