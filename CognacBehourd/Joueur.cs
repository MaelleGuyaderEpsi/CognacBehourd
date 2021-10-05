using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognacBehourd
{
    public class Joueur
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Poids { get; set; }
        public int Annee_dAdhesion { get; set; }
        public String Arme { get; set; }
        public String Armure { get; set; }
        public float Valeur { get; set; }


        public Joueur()
        {
			this.Nom = "";
			this.Prenom = "";
			this.Poids = 0;
			this.Annee_dAdhesion = 0;
			this.Arme = "";
			this.Armure = "";
			this.Valeur = 0;
		}

        public Joueur(String Nom, String Prenom, int Poids, int Annee_dAdhesion, String Arme = null, String Armure = null)
        {
			this.Nom = Nom;
			this.Prenom = Prenom;
			this.Poids = Poids;
			this.Annee_dAdhesion = Annee_dAdhesion;
			this.Arme = Arme;
			this.Armure = Armure;
			this.Valeur = 0;
		}

		public void CalculPointPoid()
		{

			if (this.Poids < 47.627)
			{
				this.Valeur = 1 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 47.627 && this.Poids < 48.988)
			{
				this.Valeur = 2 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 48.988 && this.Poids < 50.349)
			{
				this.Valeur = 3 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 50.349 && this.Poids < 51.709)
			{
				this.Valeur = 4 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 51.709 && this.Poids < 53.525)
			{
				this.Valeur = 5 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 53.525 && this.Poids < 55.338)
			{
				this.Valeur = 6 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 55.338 && this.Poids < 57.152)
			{
				this.Valeur = 7 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 57.152 && this.Poids < 58.967)
			{
				this.Valeur = 8 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 58.967 && this.Poids < 61.237)
			{
				this.Valeur = 9 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 61.237 && this.Poids < 63.503)
			{
				this.Valeur = 10 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 63.503 && this.Poids < 66.678)
			{
				this.Valeur = 11 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 66.678 && this.Poids < 69.853)
			{
				this.Valeur = 12 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 69.853 && this.Poids < 73.028)
			{
				this.Valeur = 13 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 73.028 && this.Poids < 76.205)
			{
				this.Valeur = 14 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 76.205 && this.Poids < 79.378)
			{
				this.Valeur = 15 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 79.378 && this.Poids < 90.719)
			{
				this.Valeur = 16 + pointAgeJoueur();
				return;
			}

			if (this.Poids >= 90.719)
			{
				this.Valeur = 17 + pointAgeJoueur();
				return;
			}
		}

		public float pointAgeJoueur()
		{
				return ((float)DateTime.Now.Year - this.Annee_dAdhesion) / 2;
		}
	}
}
