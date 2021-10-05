using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CognacBehourd;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTestJoueur
    {
        
        [TestMethod]
        public void Test_Constructeur_Simple()
        {
            Joueur joueur = null;
            joueur = new Joueur();
            Assert.IsNotNull(joueur);
        }

        public void Test_Constructeur_Complex()
        {
            Joueur joueur = null;
            String Nom = "Dupond";
            String Prenom = "Jean";
            int Poids = 80;
            int Annee_dAdhesion = 2020;
            String Arme = "Epee";
            String Armure = "Lourde";
            joueur = new Joueur(Nom, Prenom, Poids, Annee_dAdhesion, Arme, Armure);
            Assert.IsNotNull(joueur);
            Assert.AreEqual(joueur.Nom, Nom);
            Assert.AreEqual(joueur.Prenom, Prenom);
            Assert.AreEqual(joueur.Poids, Poids);
            Assert.AreEqual(joueur.Annee_dAdhesion, Annee_dAdhesion);
            Assert.AreEqual(joueur.Arme, Arme);
            Assert.AreEqual(joueur.Armure, Armure);
        }
    }
}
