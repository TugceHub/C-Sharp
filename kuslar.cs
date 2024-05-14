using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarVeNesneler
{
    internal class kuslar
    {
        public string isim;
       // public string ses;
        public int hız;
        public double kg;

        public virtual string sescikar()
        {
            return "buraya ses yazılacak";
        }
    }
}
