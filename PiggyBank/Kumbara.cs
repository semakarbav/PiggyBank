using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Kumbara
    {
        private List<Para> paralar;
        private double maxHacim;
        private double doluHacim;

        public Kumbara(double maxHacim)
        {
            paralar = new List<Para>();
            this.maxHacim = maxHacim;
            doluHacim = 0;
        }

        public void ParaEkle(Para para)
        {
            if (doluHacim + para.Hacim <= maxHacim)
            {
                Banknote banknote = para as Banknote;
                if (banknote != null && banknote.Katlandi)
                {
                    throw new Exception("Kağıt parayı katlamadan kumbaraya ekleyemezsiniz.");
                }

                paralar.Add(para);
                doluHacim += para.Hacim;
            }
            else
            {
                throw new Exception("Kumbara hacmi dolduğu için para ekleyemezsiniz.");
            }
        }

        public void Shake()
        {
            foreach (Para para in paralar)
            {
                double fazlaHacim = Math.Max(0.25 * para.Hacim, doluHacim * 0.25);
                double yeniHacim = para.Hacim + fazlaHacim;
                doluHacim += yeniHacim - para.Hacim;
            }
        }
    }
}
    
