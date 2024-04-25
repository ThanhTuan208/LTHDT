using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTuan_24._4_LTHDT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo x = new PhanSo(2,4);
            PhanSo y = new PhanSo(1,3);

            PhanSo z = x + y;
          
            Console.WriteLine( z.RutGon().ToString());

            if (x == y)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("!=");
            }
        }
    }
}
