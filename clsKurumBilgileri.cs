using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sayi_okuma;
using System.Threading;


namespace MikroAnaliz
{

    //public class KullaniciHat
    //{
    //    public String OdaKodu;
    //    public String Kuladi;
    //    public String Sifre;
    //    public Boolean Hatirla = false;
    //}
    class Sabitler
    {
        #region //DEĞİŞKENLERİ TANIMLAMA KISMI
        //public static string Donem = "2012"; // "2013";
        public static string Yil = "-1";
        public Thread mesajtrd;
        
        public static string KullaniciIsmi;
        public static int KullaniciKodu;

        public static Ds_GorSic_Data AraziDeger;
        public static Sicdata.T_KurumAyarDataTable Sabit;
        private string MakbuzNo;

        //public static bool Parsel_Kont_Yap;
        //public static bool Arazi_Filtresi = false;
        #endregion
        public static bool IsNumeric(string value)
        {
            foreach (char c in value)
                if (!((Int16)c > 47 && (Int16)c < 58)) return false;
            return true;
        }

        #region //SABİTLER İLK YUKLENMESİ
        public Sabitler()
        {
            // MessageBox.Show("sabit");
            if (mesajtrd == null)
            {
              
                //SONRADAN GİZLENDİ
                //mesajtrd=new Thread(frmAnaForm.status.Showtr);
            }
            if (Sabit == null)
            {
                Sabit = new Sicdata.T_KurumAyarDataTable();
                SicdataTableAdapters.T_KurumAyarTableAdapter SBTD = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                SBTD.Fill(Sabit, frm_AnaForm.KurumKodu);
            }
        }
        #endregion
        #region //SAYIYI YAZIYA ÇEVİRME KISMI
        public static string YaziIle(string deger)
        {
            string Alinansayi = "";
            string para = deger;

            para = Convert.ToString(Math.Round(Convert.ToDecimal(para), 2));
            string[] veri = para.Split(new char[] { ',' });
            Alinansayi += clsParaIslemleri.ParaOku(veri[0]) + " TL ";
            if (veri.Length > 1)
            {
                if (veri[1] != "00")
                {
                    Alinansayi += clsParaIslemleri.ParaOku(veri[1]) + " Kuruş ";
                }
            }
            return Alinansayi;
        }

        #endregion

        #region //SABİTLERİ ALMA KISMI
        public static string Kurumadi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_KURUMADI;
            }
            set
            {
                Kurumadi = value;
            }
        }
        public static int Kurumkodu
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter kurkod = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                kurkod.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_KURUMKODU;
            }
            set
            {
                Kurumkodu = value;
            }
        }
        //KURUM ADRES
        public static string KurumAdres
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter kurkod = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                kurkod.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUMADRES;
            }
            set
            {
                KurumAdres = value;
            }
        }



        public static string FirmaIl
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_IL;
            }
            set
            {
                FirmaIl = value;
            }
        }
        public static string Virguldensonra
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].VIRGULDENSONRA;
            }
            set
            {
                Virguldensonra = value;
            }
        }

        public static string FirmaIlce
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_ILCE;
            }
            set
            {
                FirmaIlce = value;
            }
        }

        public static string BaskanIsmi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].BASKAN;
            }
            set
            {
                BaskanIsmi = value;
            }
        }
        public static string GenelSekreter
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].GENELSEKRETER;
            }
            set
            {
                GenelSekreter = value;
            }
        }

        public static string Bolgesi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].BOLGESI;
            }
            set
            {
                Bolgesi = value;
            }
        }
        public static string Derinlik
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].DERINLIK;
            }
            set
            {
                Derinlik = value;
            }
        }
        public static string Tekniker1
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].TEKNIKER1;
            }
            set
            {
                Tekniker1 = value;
            }
        }

        public static string Tekniker2
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].TEKNIKER2;
            }
            set
            {
                Tekniker2 = value;
            }
        }

        public static string LaboratuvarSorumlusu1
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].LABORATUVARSORUMLU1;
            }
            set
            {
                LaboratuvarSorumlusu1 = value;
            }
        }
        public static string LaboratuvarSorumlusu2
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].LABORATUVARSORUMLU2;
            }
            set
            {
                LaboratuvarSorumlusu2 = value;
            }
        }
        public static string ZiraatMuhendisi1
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].ZIRAATMUHENDISI1;
            }
            set
            {
                ZiraatMuhendisi1 = value;
            }
        }

        public static string ZiraatMuhendisi2
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].ZIRAATMUHENDISI2;
            }
            set
            {
                ZiraatMuhendisi2 = value;
            }
        }




        public static int CalismaYili
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_DONEMI;
            }
            set
            {
                CalismaYili = value;
            }
        }

        public static bool OtomatikKayit
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].KURUM_OTOMATIKKAYIT;
            }
            set
            {
                OtomatikKayit = value;
            }
        }

        public static bool GorSonRaporTarihi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].GORSONRAPORTARIHI;
            }
            set
            {
                GorSonRaporTarihi = value;
            }
        }

        public static bool GorSonTeslimTarihi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].GORSONTESLIMTARIHI;
            }
            set
            {
                GorSonTeslimTarihi = value;
            }
        }

        public static bool GorSonTeslimAlanAdi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].GORSONTESLIMALANADI;
            }
            set
            {
                GorSonTeslimAlanAdi = value;
            }
        }

        public static bool GorSonTeslimEdenAdi
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].GORSONTESLIMEDENADI;
            }
            set
            {
                GorSonTeslimEdenAdi = value;
            }
        }


        public static decimal AnalizUstSiniri
        {
            get
            {
                Sicdata end = new Sicdata();
                SicdataTableAdapters.T_KurumAyarTableAdapter endp = new SicdataTableAdapters.T_KurumAyarTableAdapter();
                endp.Fill(end.T_KurumAyar, frm_AnaForm.KurumKodu);
                return end.T_KurumAyar[0].ANALIZUSTSINIRI;
            }
            set
            {
                AnalizUstSiniri = value;
            }
        }


        #endregion
    
        #region //MAKBUZ NUMARASI ALMA KISMI
        public void MakbuzNoArtir(bool durum)
        {
            if (durum)
            {
                long makno = 0;
                Ds_GorSic_Data gordat = new Ds_GorSic_Data();
                Ds_GorSic_DataTableAdapters.Gor_SpMakbuzNoAlTableAdapter grdm = new Ds_GorSic_DataTableAdapters.Gor_SpMakbuzNoAlTableAdapter();
                grdm.Fill(gordat.Gor_SpMakbuzNoAl, Sabitler.Kurumkodu);
                makno = (gordat.Gor_SpMakbuzNoAl[0].Makno);

                Ds_GorSic_DataTableAdapters.SpMakbuzNoSecTableAdapter mkno = new Ds_GorSic_DataTableAdapters.SpMakbuzNoSecTableAdapter();
                mkno.Fill(gordat.SpMakbuzNoSec, Convert.ToString(frm_AnaForm.KurumKodu));
                gordat.SpMakbuzNoSec[0].Sabit_Mak = int.Parse((makno + 1).ToString());
                mkno.Update(gordat.SpMakbuzNoSec);
            }
        }
    
        public string makbuzno
        {
            get
            {
                long makno = 0;
                Ds_GorSic_Data gordat = new Ds_GorSic_Data();
                Ds_GorSic_DataTableAdapters.Gor_SpMakbuzNoAlTableAdapter grdm = new Ds_GorSic_DataTableAdapters.Gor_SpMakbuzNoAlTableAdapter();
                grdm.Fill(gordat.Gor_SpMakbuzNoAl, Sabitler.Kurumkodu);
                makno = (gordat.Gor_SpMakbuzNoAl[0].Makno);

                return makno.ToString();
            }
            set { MakbuzNo = value; }

        }
        #endregion
        #region //İKİNCİ ÜRÜNLERİN HESABA KATILIP KATILMAYACAĞI KISMI
        //public static bool IkinciUrunHesapla
        //{
        //    //get
        //    //{
        //    //    SicdataTableAdapters.T_KurumAyarTableAdapter end = new SicdataTableAdapters.T_KurumAyarTableAdapter();
        //    //    Sicdata endata = new Sicdata();
        //    //    end.Fill(endata.T_KurumAyar, frm_AnaForm.KurumKodu);

        //    //    return endata.T_KurumAyar[0].KURUM_2NCIURUNHESAPLA;
        //    //}
        //    //set
        //    //{
        //    //    IkinciUrunHesapla = value;
        //    //}
        //}
        #endregion
      
    }

}
