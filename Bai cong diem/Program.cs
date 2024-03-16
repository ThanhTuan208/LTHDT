using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo y = new PhanSo(3,4);
            PhanSo x = new PhanSo(2, 4);
            x.Print();
            y.Print();
            PhanSo z = x.TinhTong(y);
            z.Print();
            z = x.TinhTru(y);
            z.Print();
            z = x.TinhNhan(y);
            z.Print();
            z = x.TinhChia(y);
            z.Print();
        }
    }
}
