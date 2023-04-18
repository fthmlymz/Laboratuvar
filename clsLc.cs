using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikroAnaliz
{
    class CpuBilgi
    {
        public static string CpuId()
        {
            string Cpuid = "";
            string querykod = "SELECT ProcessorId FROM Win32_Processor";
            System.Management.ManagementObjectSearcher query = new System.Management.ManagementObjectSearcher(querykod);
            System.Management.ManagementObjectCollection Collection = query.Get();
            foreach (System.Management.ManagementObject oManagementObject in Collection)
            {
                Cpuid = (string)oManagementObject["ProcessorId"];
            }
            return (Cpuid);
        }
        //public static string Aktivasyon()
        //{
        //    string AktivasyonKey = "";
        //    Random Rastgele = new Random();
        //    int Serial = Rastgele.Next(0, 10);
        //    Random Harf = new Random();
        //    int Serial2 = Harf.Next(65, 91);
        //    char Karakter = Convert.ToChar(Serial2);
        //    int Seri, Seri2, Seri3, Seri4, Seri5, Seri6;
        //    char deger1, deger2, deger3;
        //    Seri = Rastgele.Next(1, 8);
        //    Seri2 = Rastgele.Next(1, 8);
        //    Seri3 = Rastgele.Next(1, 8);
        //    Seri4 = Harf.Next(65, 91);
        //    Seri5 = Harf.Next(65, 91);
        //    Seri6 = Harf.Next(65, 91);
        //    deger1 = Convert.ToChar(Seri4);
        //    deger2 = Convert.ToChar(Seri5);
        //    deger3 = Convert.ToChar(Seri6);
        //    AktivasyonKey = Seri.ToString() + Seri2.ToString() + Seri3.ToString() + deger1.ToString() + deger2.ToString() + deger3.ToString() + Karakter.ToString() + Serial.ToString();
        //    return (AktivasyonKey);
        //}

    }
}
