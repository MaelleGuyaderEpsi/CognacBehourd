using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognacBehourd
{
    public class Equipe
    {
        public String Nom { get; set; }
        public List<Joueur> Joueurs { get; set; }

        public Equipe()
        {

        }
        public Equipe(string NomEquipe, List<Joueur> JoueursEquipe)
        {
            Nom = NomEquipe;
            Joueurs = JoueursEquipe;
        }

        public void addJoueur(Joueur joueur)
        {
            Joueurs.Add(joueur);
        }

        public void removeJoueur(Joueur joueur)
        {
            Joueurs.Remove(joueur);
        }
    }
}
