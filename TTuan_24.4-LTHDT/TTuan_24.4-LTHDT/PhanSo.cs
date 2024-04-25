using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTuan_24._4_LTHDT
{
    internal class PhanSo
    {
        private int tuso, mauso;
        public PhanSo() { }

        public PhanSo(int tuso, int mauso)
        {
            Tuso = tuso;
            Mauso = mauso;
        }

        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else b -= a;
            }
            return a;
        }
        public PhanSo RutGon()
        {
            int ucln = UCLN(Math.Abs(Tuso), Math.Abs(Mauso));
            int tu = Tuso / ucln;
            int mau = Mauso / ucln;
            return new PhanSo(tu,mau);
        }

        public int Tuso { get => tuso; set => tuso = value; }
        public int Mauso { get => mauso; set => mauso = value; }

        public  new string ToString()
        {
            return $"phan so = {Tuso}/{Mauso}";
        }
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            int TuSo = ps1.Tuso * ps2.Mauso + ps1.Mauso * ps2.Tuso;
            int MauSo = ps1.Mauso * ps2.Mauso;

            return new PhanSo(TuSo, MauSo);
        } 
        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            if (ps1.Tuso * ps2.Mauso == ps1.Mauso * ps2.Tuso)
            {
                return true;
            }
            return false;                 
        } public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            if (ps1.Tuso * ps2.Mauso == ps1.Mauso * ps2.Tuso)
            {
                return false;
            }
            return true;                 
        }
    }
}
