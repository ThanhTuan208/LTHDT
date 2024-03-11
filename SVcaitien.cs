using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hướng_đối_tượng
{
    internal class SVcaitien
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail  { get; set; }

        public override string ToString()
        {
            return Name + "\t" + Phone +"\t"+ Mail ;
        }
    }

}
