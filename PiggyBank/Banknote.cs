using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Banknote : Para
    {
        public bool Katlandi { get; private set; }

        public Banknote(string isim, decimal deger)
        {
            Isim = isim;
            Deger = deger;
            Katlandi = false;
        }

        public void Katla()
        {
            if (!Katlandi)
            {
                Constants.Banknote.En /= 4;
                Constants.Banknote.Yukseklik *= 4;
                Katlandi = true;
                Console.WriteLine("Banknote katlandı.");
            }
            else
            {
                Console.WriteLine("Banknote zaten katlanmış durumda.");
            }
        }

        public override double Hacim
        {
            get { return Constants.Banknote.En * Constants.Banknote.Boy * Constants.Banknote.Yukseklik; }
        }
    }
}
