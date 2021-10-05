using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognacBehourd
{
    class PointJoueur
    {
        public void CalculPointPoid(Joueur joueur)
        {

			int nbJoueur = 0;
			int nbJoueurParEquipe = 0;
			int pointPoidsJoueur = 0;
			
			float poidsJoueur = 0;

			int[] tabPointJoueur = new int[];

			nbJoueurParEquipe = nbJoueur / 2;


			if (poidsJoueur < 47.627)
			{
				joueur.Valeur = 1 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 47.627 && poidsJoueur < 48.988)
			{
				joueur.Valeur = 2 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 48.988 && poidsJoueur < 50.349)
			{
				joueur.Valeur = 3 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 50.349 && poidsJoueur < 51.709)
			{
				joueur.Valeur = 4 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 51.709 && poidsJoueur < 53.525)
			{
				joueur.Valeur = 5 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 53.525 && poidsJoueur < 55.338)
			{
				joueur.Valeur = 6 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 55.338 && poidsJoueur < 57.152)
			{
				joueur.Valeur = 7 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 57.152 && poidsJoueur < 58.967)
			{
				joueur.Valeur = 8 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 58.967 && poidsJoueur < 61.237)
			{
				joueur.Valeur = 9 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 61.237 && poidsJoueur < 63.503)
			{
				joueur.Valeur = 10 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 63.503 && poidsJoueur < 66.678)
			{
				joueur.Valeur = 11 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 66.678 && poidsJoueur < 69.853)
			{
				joueur.Valeur = 12 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 69.853 && poidsJoueur < 73.028)
			{
				joueur.Valeur = 13 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 73.028 && poidsJoueur < 76.205)
			{
				joueur.Valeur = 14 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 76.205 && poidsJoueur < 79.378)
			{
				joueur.Valeur = 15 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 79.378 && poidsJoueur < 90.719)
			{
				joueur.Valeur = 16 + pointAgeJoueur(joueur);
			}

			if (poidsJoueur >= 90.719)
			{
				joueur.Valeur = 17 + pointAgeJoueur(joueur);
			}
		}

		public float pointAgeJoueur(Joueur joueur)
        {
			bool adherent = false;

			if (adherent == true)
			{
				return (DateTime.Now.Year - joueur.Annee_dAdhesion) / 2;

			}
			else
			{
				return 0;
			}
		}
    }
}
