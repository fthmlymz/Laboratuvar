using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MikroAnaliz
{
    
    public class PortAccess
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int adress, int value);
        [DllImport("inpout32.dll", EntryPoint = "Inp32")]
        public static extern void Input(int adress);
    }
}
