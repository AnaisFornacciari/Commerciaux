using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    class FraisRepas : NoteFrais
    {
        public double midi { get; set; }

        public FraisRepas(DateTime date, Commercial c, double midi)
            :base(date, c)
        {
            this.midi = midi;
        }

        public override double calculMontantARembourser()
        {
            char cat = this.commercial.categorie;
            double montant = 0;
            switch (cat)
            {
                case 'A': 
                    if (this.midi < 25)
                    {
                        montant = this.midi;
                    }
                    else
                    {
                        montant = 25;
                    }
                    break;
                case 'B': 
                    if (this.midi < 22)
                    {
                        montant = this.midi;
                    }
                    else
                    {
                        montant = 22;
                    }
                    break;
                case 'C': 
                    if (this.midi < 20)
                    {
                        montant = this.midi;
                    }
                    else
                    {
                        montant = 20;
                    }
                    break;
            }
            return montant;
        }
    }
}
