using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    class ServiceCommercial
    {
        public List<Commercial> listeCommercials { get; set; }

        public ServiceCommercial()
        {
            this.listeCommercials = new List<Commercial>();
        }

        public void ajouterCommercial(Commercial c)
        {
            this.listeCommercials.Add(c);
        }

        public int nbFraisNonRembourses()
        {
            int nb = 0;
            foreach (Commercial c in listeCommercials)
            {
                foreach (NoteFrais f in c.listeFrais)
                {
                    if (!f.etat)
                    {
                        nb++;
                    }
                }
            }
            return nb;
        }


    }
}
