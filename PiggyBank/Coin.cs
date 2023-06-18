using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Coin : Para
    {
        private double yaricap;
        private double yukseklik;

        public Coin(string isim, decimal deger, double yaricap, double yukseklik)
        {
            Isim = isim;
            Deger = deger;
            this.yaricap = yaricap;
            this.yukseklik = yukseklik;
        }

        public override double Hacim
        {
            get { return Constants.PI * Math.Pow(yaricap, 2) * yukseklik; }
        }
    }
}
