using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace CognacBehourd
{
    public static class Algo
    {
        public static void affecterEquipe(List<Joueur> joueurs, Equipe equipe1, Equipe equipe2)
        {
            if(joueurs.Count < 2)
            {
                throw new MyException("Team length not valid");
            }
            equipe1.Joueurs.Clear();
            equipe2.Joueurs.Clear();
            float valeurEquipe1 = 0;
            float valeurEquipe2 = 0;
            int nbJoueurMaxByTeam;
            if (joueurs.Count % 2 > 0)
                nbJoueurMaxByTeam = joueurs.Count / 2 + 1;
            else
                nbJoueurMaxByTeam = joueurs.Count / 2;

            while (joueurs.Count > 0)
            {
                Joueur meilleurJoueur = joueurs.MaxBy(x => x.Valeur).First();
                if (equipe1.Joueurs.Count >= nbJoueurMaxByTeam)
                {
                    equipe2.addJoueur(meilleurJoueur);
                    joueurs.Remove(meilleurJoueur);
                    continue;
                }
                else if (equipe2.Joueurs.Count >= nbJoueurMaxByTeam)
                {
                    equipe1.addJoueur(meilleurJoueur);
                    joueurs.Remove(meilleurJoueur);
                    continue;
                }

                if (valeurEquipe1 > valeurEquipe2)
                {
                    equipe2.addJoueur(meilleurJoueur);
                    valeurEquipe2 += meilleurJoueur.Valeur;
                    joueurs.Remove(meilleurJoueur);
                }
                else
                {
                    equipe1.addJoueur(meilleurJoueur);
                    valeurEquipe1 += meilleurJoueur.Valeur;
                    joueurs.Remove(meilleurJoueur);
                }
            }
        }
    }
}
