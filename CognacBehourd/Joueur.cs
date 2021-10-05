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


        public Joueur()
        {

        }
        public Joueur(String Nom, String Prenom, int Poids, int Annee_dAdhesion, String Arme = null, String Armure = null)
        {

        }

        
    }
}
