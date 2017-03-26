using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    [System.Serializable]
    class FraisTransport : NoteFrais
    {
        public int km { get; set; }

        public FraisTransport(DateTime date, Commercial c, int km)
            :base(date, c)
        {
            this.km = km;
        }

        public override double calculMontantARembourser()
        {
            int pv = this.commercial.puissanceV;
            double montant = 0;
            if (pv > 5)
            {
                montant += 0.1 * this.km;
            }
            else if (pv >= 10)
            {
                montant += 0.2 * this.km;
            }
            else
            {
                montant += 0.3 * this.km;
            }
            return montant;
        }
    }
}
