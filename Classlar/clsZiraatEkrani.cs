using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikroAnaliz.Classlar
{
    class clsZiraatEkrani
    {
        public static frm_Durum status;
        
        public string UserList(Boolean Dialog = false)
        {
            //MikroAnaliz.UserModul.frUserList frm = new UserModul.frUserList();
            //frm.SelectForOpen = true;
            //frm.ShowDialog();
            return frm_AnaForm.AraDegiskenString;
        }

        public void KullaniciIzinleri(Boolean Ac = false, string Id = "-1")
        {
            //MikroAnaliz.UserModul.frIzinler izin = new UserModul.frIzinler();
            //izin.MdiParent = frm_AnaForm.ActiveForm;
            //if (Ac)
            //{
            //    izin.Ac(Id);
            //}
            //izin.Show();
        }
        public void KullaniciEkle()
        {
            frm_KullaniciKaydet frm = new frm_KullaniciKaydet();
            frm.ShowDialog();
        }
        public void UyeListesiAc()
        {
            frm_UyeListesi sclf = new frm_UyeListesi();
            sclf.MdiParent = frm_AnaForm.ActiveForm; ;
            sclf.Show();
        }

        public void YeniUyeKayit()
        {
            frm_UyeFormu.uyeSicilNumarasi = 999999;
            frm_UyeFormu frm = new frm_UyeFormu();

            Sicdata.SicillerRow sic;

            sic = frm.enData.Siciller.NewSicillerRow();
            sic.UYE_KURUMKODU = Sabitler.Kurumkodu;
            sic.KAYITTARIHI = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
            sic.UYE_KAYITTARIHI = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
            sic.UYE_GIRISTRH = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
            sic.UYE_MEDENIHAL = "EVLİ";
            sic.UYE_MEZUNIYET = "";
            sic.UYE_CINSIYET = "ERKEK";
            sic.SIGORTA = "SSK";
            sic.UYE_DURUMU = true;
            sic.UYE_KOD = "999999";
            sic.UYE_IL = "";
            sic.UYE_ILCE = "";
            //sic.UYE_MAHALLE = "1";
            sic.UYE_BOLGESI = Sabitler.Bolgesi;
            sic.UYE_DERINLIK = Sabitler.Derinlik;
            frm.enData.Siciller.AddSicillerRow(sic);
            frm.enData.Islemler.Clear();
            frm_UyeFormu.uyeSicilNumarasi = 999999;
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
          }

        //public void KullaniciDegistir()
        //{
        //    frmAnaForm frm = new frmAnaForm();
        //    frm.Giris_Yap();
        //}

        public void Borclular()
        {
            frm_Borclular frm = new frm_Borclular();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }
        public void VezneBordro()
        {
            frm_VezneBordro frm = new frm_VezneBordro();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

       
        public void ParolaDegistir()
        {
            frm_ParolaDegistir frm = new frm_ParolaDegistir();
            frm.ShowDialog();
        }
        public void BaglantiSahibi()
        {
            frm_Database frm = new frm_Database();
            //frm.MdiParent = frmAnaForm.ActiveForm;
            frm.ShowDialog();
            //status.Gizle();
        }
       
        public void BorcIslemleri()
        {
            frm_BorcTipleri frmi = new frm_BorcTipleri();
            frmi.MdiParent = frm_AnaForm.ActiveForm;
            frmi.Show();
        }
        
        public void BelgeTanimla()
        {
            frmBelgeTuruTanimlama frm = new frmBelgeTuruTanimlama();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        #region TOPRAK ANALİZ BAŞLANGIC
        public void AnalizDeger()
        {
            Toprak.frmAnalizDegerleri frm = new Toprak.frmAnalizDegerleri();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void ToprakAnalizSabitleri()
        {
            Toprak.frmAnalizSabitleri frm = new Toprak.frmAnalizSabitleri();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void AzotluGubreTablosu()
        {
            Toprak.frmAzotluGubreler frm = new Toprak.frmAzotluGubreler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void FosforluGubreTablosu()
        {
            Toprak.frmFosforluGubreler frm = new Toprak.frmFosforluGubreler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void PotasyumluGubreTablosu()
        {
            Toprak.frmPotasyumluGubreler frm = new Toprak.frmPotasyumluGubreler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void ililcelistesi()
        {
            Toprak.frmIlIlcelistesi frm = new Toprak.frmIlIlcelistesi();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void Gruplar()
        {
            Toprak.frmGruplar frm = new Toprak.frmGruplar();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void SulamaSekli()
        {
            Toprak.frmSulamaSekli frm = new Toprak.frmSulamaSekli();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void MahalleListesi()
        {
            frmMahalleListesi frm = new frmMahalleListesi();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void Kurumayarlari()
        {
            frmKurumAyarlari frm = new frmKurumAyarlari();
            frm.ShowDialog();
        }

        public void Derinlikler()
        {
            Toprak.frmDerinlikler frm = new Toprak.frmDerinlikler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void TopluBelgeEkrani()
        {
            frmTopluBelgeYaz frm = new frmTopluBelgeYaz();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void GubreHesaplamaFormu()
        {
            Toprak.frmGubreHesaplama frm = new Toprak.frmGubreHesaplama();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.mnuBirinciye.Visible = false;
            frm.mnuikinciye.Visible = false;
            frm.mnuoneri.Visible = false;
            frm.Show();
        }

        public void GubreYorumlari()
        {
            frmUrunYorumlari frm = new frmUrunYorumlari();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void Meslekler()
        {
            frmMeslekler frm = new frmMeslekler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void KayitTurleri()
        {
            frmKayitTurleri frm = new frmKayitTurleri();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }
        #endregion

        #region RAPORLAR
        public void FaaliyetRaporlariTarihli()
        {
            Raporlamalar.frmFaaliyetRaporlari frm = new Raporlamalar.frmFaaliyetRaporlari();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void Defterler()
        {
            Raporlamalar.frmToprakDefterler frm = new Raporlamalar.frmToprakDefterler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void Urunler()
        {
            Toprak.frmUrunler frm = new Toprak.frmUrunler();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

        public void GelmeyenlerListesi()
        {
            Raporlamalar.frmBiryildaOlanOlmayan frm = new Raporlamalar.frmBiryildaOlanOlmayan();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }
       
        
        #endregion

        public void BuharTablosu()
        {
            Toprak.frmBuharTablosu frm = new Toprak.frmBuharTablosu();
            frm.ShowDialog();
        }

        public void TopluToprakAnalizSonucuGiris()
        {
            Toprak.frmTopluToprakAnalizGiris frm = new Toprak.frmTopluToprakAnalizGiris();
            frm.MdiParent = frm_AnaForm.ActiveForm;
            frm.Show();
        }

    }
}
