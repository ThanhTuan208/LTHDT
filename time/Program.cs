using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            time time = new time(22,59,59);
            Console.WriteLine(time.ToString());
            Console.WriteLine(time.nextSecond().ToString());
            Console.WriteLine(time.nextprevious().ToString());

        }
    }
}
