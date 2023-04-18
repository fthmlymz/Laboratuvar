using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SicilNet.Classlar
{
    class Mesaj
    {
        public Boolean Sor(string Mesaj)
        {
            DialogResult Sor = new DialogResult();
            Sor=MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor==DialogResult.Yes)
            {
            return true;
            }
            return false;
        }
        public void BilgiVer(string msj)
        {
            MessageBox.Show(msj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UyariVer(string msj)
        {
            MessageBox.Show(msj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Hata()
        {
            MessageBox.Show("BİR HATA MEYDANA GELDİ. LÜTFEN DEĞERLERİ KONTROL EDİN", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }




}
