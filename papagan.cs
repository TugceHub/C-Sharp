using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarVeNesneler
{
    internal class papagan : kuslar  // kalıtım için  : dan sonra referans alacağımız class isimi
    {
        public string tur;
        public string renk;

        public override string sescikar()
        {
            return "cik ciik";
        }

    }
}
