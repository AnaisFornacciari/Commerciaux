using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    class FraisNuite : NoteFrais
    {
        public double soir { get; set; }
        public double matin { get; set; }
        public int region { get; set; }

        public FraisNuite(DateTime date, Commercial c, double soir, double matin, int region)
            :base(date, c)
        {
            this.soir = soir;
            this.matin = matin;
            this.region = region;
        }

        public override double calculMontantARembourser()
        {
            char cat = this.commercial.categorie;
            double montant = 0;
            switch (cat)
            {
                case 'A': 
                    if ((this.soir + this.matin) < 65)
                    {
                        montant = this.soir + this.matin;
                    }
                    else
                    {
                        montant = 65;
                    }
                    break;
                case 'B': 
                    if ((this.soir + this.matin) < 55)
                    {
                        montant = this.soir + this.matin;
                    }
                    else
                    {
                        montant = 55;
                    }
                    break;
                case 'C': 
                    if ((this.soir + this.matin) < 50)
                    {
                        montant = this.soir + this.matin;
                    }
                    else
                    {
                        montant = 50;
                    }
                    break;
            }
            switch (region)
            {
                case 1: montant *= 0.90;
                    break;
                case 2: montant *= 1;
                    break;
                case 3: montant *= 1.15;
                    break;
            }
            return montant;
        }
    }
}
