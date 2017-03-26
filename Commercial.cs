using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TPCommerciaux
{
    class Commercial
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int puissanceV { get; set; }
        public char categorie { get; set; }
        public List<NoteFrais> listeFrais { get; set; }

        public Commercial(string nom, string prenom, int puissanceV, char categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.puissanceV = puissanceV;
            this.categorie = categorie;
            this.listeFrais = new List<NoteFrais>();
        }

        public void ajouterNoteFrais(NoteFrais f)
        {
            this.listeFrais.Add(f);
        }

        public override string ToString()
        {
            return "Nom : " + nom + "/n Prenom : " + prenom + "/n Puissance voiture : " + puissanceV + "/n Catégorie : " + categorie;
        }
    }
}
