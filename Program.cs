using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCommerciaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial c = new Commercial("Jean", "Dupond", 8, 'A');

            NoteFrais nf = new NoteFrais(DateTime.Now, c);
            FraisNuite fn = new FraisNuite(DateTime.Now, c, 10, 10, 1);
            FraisRepas fr = new FraisRepas(DateTime.Now, c, 10);
            FraisTransport ft = new FraisTransport(DateTime.Now, c, 1000);

            fn.setMontantARembourser();
            fr.setMontantARembourser();
            ft.setMontantARembourser();
            nf.setEtatToTrue();

            Console.WriteLine(nf.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
 