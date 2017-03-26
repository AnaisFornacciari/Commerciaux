using TPCommerciaux;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCommercial
{
    
    
    /// <summary>
    ///Classe de test pour ServiceCommercialTest, destinée à contenir tous
    ///les tests unitaires ServiceCommercialTest
    ///</summary>
    [TestClass()]
    public class ServiceCommercialTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour nbFraisNonRembourses
        ///</summary>
        [TestMethod()]
        public void nbFraisNonRemboursesTest()
        {
            ServiceCommercial sc = new ServiceCommercial();
            Commercial c = new Commercial("Jean", "Dupond", 25, 'A');
            Commercial c1 = new Commercial("Paul", "Duval", 10, 'B');
            sc.ajouterCommercial(c);
            sc.ajouterCommercial(c1);
            NoteFrais f = new NoteFrais(new DateTime(2013, 11, 12), c);
            NoteFrais f1 = new NoteFrais(new DateTime(2013, 11, 15), c);
            f1.setEtatToTrue();
            NoteFrais f2 = new NoteFrais(new DateTime(2013, 11, 18), c1);
            NoteFrais f3 = new NoteFrais(new DateTime(2013, 11, 22), c1);
            f3.setEtatToTrue();
            NoteFrais f4 = new NoteFrais(new DateTime(2013, 11, 25), c1);
            f4.setEtatToTrue();
            Assert.AreEqual(2, sc.nbFraisNonRembourses());
        }
    }
}
