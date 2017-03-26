using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    class NoteFrais
    {
        public int numero { get; set; }
        public DateTime date { get; set; }
        public double montantR { get; set; }
        public bool etat { get; set; }
        public Commercial commercial { get; set; }

        public NoteFrais(DateTime date, Commercial c)
        {
            this.numero = c.listeFrais.Count + 1;
            this.date = date;
            this.montantR = 0;
            this.etat = false;
            this.commercial = c;
            this.commercial.ajouterNoteFrais(this);
        }

        public void setEtatToTrue()
        {
            this.etat = true;
        }

        public void setMontantARembourser()
        {
            this.montantR = calculMontantARembourser();
        }

        virtual public double calculMontantARembourser()
        {
            return 0;
        }

        public override string ToString()
        {
            string Etat = "Non remboursé";
            if(etat)
            {
                Etat = "Remboursé";
            }
            return "Numéro : " + numero + "/n Date : " + date + "/n Montant à rembourser :" + montantR + "/n" + Etat;
        }
    }
}
