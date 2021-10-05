using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CognacBehourd;

namespace TestUnitaire
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestEquipe
    {

        public UnitTestEquipe()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
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
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        
        
        [TestMethod]
        public void Creation_Equipe_Vide()
        {
            List<Joueur> ListJoueurVide = new List<Joueur>();

            Equipe equipeVide = new Equipe("equipeVide", ListJoueurVide);
            Assert.IsNotNull(equipeVide);
            Assert.IsTrue(ListJoueurVide.Count == 0);
        }

        [TestMethod]
        public void Creation_Equipe_Pleine()
        {
            List<Joueur> ListJoueurPleine = new List<Joueur>();
            Joueur joueur1 = new Joueur("GROS", "Paul", 134, 2006, "Hache 2M", "Mailles");
            Joueur joueur2 = new Joueur("BLANC", "Louis", 47, 2020, "Dagues", "Mailles");
            Joueur joueur3 = new Joueur("GIRAUD", "Jean-Michel", 79, 1987, "Sabre", "Plaques");
            Joueur joueur4 = new Joueur("PARIS", "Théophile", 102, 2003, "Hallebarde", "Gambison");

            ListJoueurPleine.Add(joueur1);
            ListJoueurPleine.Add(joueur2);
            ListJoueurPleine.Add(joueur3);
            ListJoueurPleine.Add(joueur4);

            Equipe equipePleine = new Equipe("equipePleine", ListJoueurPleine);
            Assert.IsTrue(ListJoueurPleine.Count != 0);
        }

        [TestMethod]
        public void Ajout_Joueur()
        {
            List<Joueur> ListJoueurAjout = new List<Joueur>();
            Equipe equipeAjout = new Equipe("equipeAjout", ListJoueurAjout);
            Assert.IsTrue(ListJoueurAjout.Count == 0);

            Joueur joueur1 = new Joueur("GROS", "Paul", 134, 2006, "Hache 2M", "Mailles");

            equipeAjout.addJoueur(joueur1);

            Assert.IsTrue(ListJoueurAjout.Count != 0 );
        }

        [TestMethod]
        public void Suppression_Joueur()
        {
            List<Joueur> ListJoueurSupp = new List<Joueur>();
            Joueur joueur1 = new Joueur("GROS", "Paul", 134, 2006, "Hache 2M", "Mailles");
            ListJoueurSupp.Add(joueur1);
            Assert.IsTrue(ListJoueurSupp.Count != 0);

            Equipe equipeSupp = new Equipe("equipeAjout", ListJoueurSupp);

            equipeSupp.removeJoueur(joueur1);

            Assert.IsTrue(ListJoueurSupp.Count == 0);
        }
    }
}
