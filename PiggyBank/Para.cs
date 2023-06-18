using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public abstract class Para
    {
        public string Isim { get; protected set; }
        public decimal Deger { get; protected set; }
        public abstract double Hacim { get; }
    }

}
