using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;

namespace MikroAnaliz
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BonusSkins).Assembly);

            Application.EnableVisualStyles();

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new acilis());
            Application.Run(new frm_AnaForm());
        }
    }
}
