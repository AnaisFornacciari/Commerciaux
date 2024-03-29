﻿using TPCommerciaux;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCommercial
{
    
    
    /// <summary>
    ///Classe de test pour CommercialTest, destinée à contenir tous
    ///les tests unitaires CommercialTest
    ///</summary>
    [TestClass()]
    public class CommercialTest
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
        ///Test pour ajouterNoteFrais
        ///</summary>
        [TestMethod()]
        public void ajouterNoteFraisTest()
        {
            Commercial c = new Commercial("Jean", "Dupond", 25, 'A');
            NoteFrais f, f1;
            f = new NoteFrais(new DateTime(2013, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2013, 11, 15), c);
            Assert.AreEqual(2, c.listeFrais.Count);
        }
    }
}
