﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CognacBehourd;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTestJoueur
    {
        
        [TestMethod]
        public void Test_du_Constructeur_Simple()
        {
            Joueur joueur = null;
            joueur = new Joueur();
            Assert.IsNotNull(joueur);
        }

        [TestMethod]
        public void Test_du_Constructeur_Complet()
        {
            String Nom = "Dupond";
            String Prenom = "Jean";
            int Poids = 80;
            int Annee_dAdhesion = 2020;
            String Arme = "Epee";
            String Armure = "Lourde";
            Joueur joueur = new Joueur(Nom, Prenom, Poids, Annee_dAdhesion, Arme, Armure);
            Assert.AreEqual(joueur.Nom, Nom);
            Assert.AreEqual(joueur.Prenom, Prenom);
            Assert.AreEqual(joueur.Poids, Poids);
            Assert.AreEqual(joueur.Annee_dAdhesion, Annee_dAdhesion);
            Assert.AreEqual(joueur.Arme, Arme);
            Assert.AreEqual(joueur.Armure, Armure);
        }

        [TestMethod]
        public void Test_du_Calcule_de_la_Valeur_d_un_Joueur()
        {
            Joueur joueur1 = new Joueur("GROS", "Paul", 134, 2006, "Hache 2M", "Mailles");
            Joueur joueur2 = new Joueur("BLANC", "Louis", 47, 2020, "Dagues", "Mailles");

            joueur1.CalculPointPoid();
            joueur2.CalculPointPoid();

            Assert.AreEqual(joueur1.Valeur, 21.5);
            Assert.AreEqual(joueur2.Valeur, 1.5);
        }
    }
}
