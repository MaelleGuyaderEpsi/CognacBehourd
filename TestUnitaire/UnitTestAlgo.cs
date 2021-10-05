using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CognacBehourd;
using static CognacBehourd.Algo;

namespace TestUnitaire
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestAlgo
    {
        public UnitTestAlgo()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
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
        public void Test_Grand_Nombre_De_Joueur()
        {
            List<Joueur> joueurs = new List<Joueur>();
            for(int i = 0; i < 2000; i++)
            {
                joueurs.Add(new Joueur("Nom" + i, "Prenom" + i, i, i, "Arme" + i, "Armure" + i));
            }

            
            Equipe equipe1 = new Equipe("Equipe1", new List<Joueur>());
            Equipe equipe2 = new Equipe("Equipe2", new List<Joueur>());

            foreach (Joueur joueur in joueurs)
            {
                joueur.CalculPointPoid();
            }
            affecterEquipe(joueurs, equipe1, equipe2);

            foreach (Joueur joueur in joueurs)
            {
                joueur.CalculPointPoid();
            }
            //Assert.AreEqual(equipe2.Joueurs.Count)

        }

        [TestMethod]
        public void Test_Impair()
        {
            List<Joueur> joueurs = new List<Joueur>();

            Joueur joueur1 = new Joueur("Jacquie", "Michel", 130, 1998, "Hache 2M", "Mailles");
            Joueur joueur2 = new Joueur("Martin", "Dupont", 80, 2020, "Dagues", "Mailles");
            Joueur joueur3 = new Joueur("Truc", "Muche", 60, 2005, "Dagues", "Mailles");
            Joueur joueur4 = new Joueur("Maëlle", "Guyader", 85, 2021, "Dagues", "Mailles");
            Joueur joueur5 = new Joueur("Marc", "Muche", 60, 2005, "Dagues", "Mailles");


            joueurs.Add(joueur5);
            joueurs.Add(joueur4);
            joueurs.Add(joueur3);
            joueurs.Add(joueur2);
            joueurs.Add(joueur1);

            Equipe equipe1 = new Equipe("Equipe1", new List<Joueur>());
            Equipe equipe2 = new Equipe("Equipe2", new List<Joueur>());
            
            foreach (Joueur joueur in joueurs)
            {
                joueur.CalculPointPoid();
            }
            affecterEquipe(joueurs, equipe1, equipe2);

            int countEquipe1 = equipe1.Joueurs.Count;
            int countEquipe2 = equipe2.Joueurs.Count;

            Assert.AreEqual(Math.Abs(countEquipe1 - countEquipe2), 1);
        }

        [TestMethod]
        public void Test_Pair()
        {
            List<Joueur> joueurs = new List<Joueur>();

            Joueur joueur1 = new Joueur("Jacquie", "Michel", 130, 1998, "Hache 2M", "Mailles");
            Joueur joueur2 = new Joueur("Martin", "Dupont", 80, 2020, "Dagues", "Mailles");
            Joueur joueur3 = new Joueur("Truc", "Muche", 60, 2005, "Dagues", "Mailles");
            Joueur joueur4 = new Joueur("Maëlle", "Guyader", 85, 2021, "Dagues", "Mailles");

            joueurs.Add(joueur4);
            joueurs.Add(joueur3);
            joueurs.Add(joueur2);
            joueurs.Add(joueur1);

            Equipe equipe1 = new Equipe("Equipe1", new List<Joueur>());
            Equipe equipe2 = new Equipe("Equipe2", new List<Joueur>());

            foreach (Joueur joueur in joueurs)
            {
                joueur.CalculPointPoid();
            }
            affecterEquipe(joueurs, equipe1, equipe2);

            int countEquipe1 = equipe1.Joueurs.Count;
            int countEquipe2 = equipe2.Joueurs.Count;

            Assert.AreEqual(Math.Abs(countEquipe1 - countEquipe2), 0);
        }
    }
}
