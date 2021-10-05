using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;
using static CognacBehourd.Algo;

namespace CognacBehourd
{
    public partial class MainForm : Form
    {
        List<Joueur> joueurs = new List<Joueur>();
        Equipe equipe1 = new Equipe("Equipe1", new List<Joueur>());
        Equipe equipe2 = new Equipe("Equipe2", new List<Joueur>());

        public MainForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            joueurs.Clear();
            foreach (DataGridViewRow row in dgvParticipant.Rows)
            {
                if ((String)row.Cells[0].Value == "" || (String)row.Cells[0].Value == null)
                    continue;
                joueurs.Add(new Joueur(
                    (String)row.Cells[0].Value,
                    (String)row.Cells[1].Value,
                    int.Parse((string)row.Cells[2].Value),
                    int.Parse((string)row.Cells[3].Value),
                    (String)row.Cells[4].Value,
                    (String)row.Cells[5].Value));
            }
            foreach (Joueur joueur in joueurs)
            {
                joueur.CalculPointPoid();
            }
            affecterEquipe(joueurs,equipe1,equipe2);
            afficherEquipes();
        }

        public void afficherEquipes()
        {
            dgvEquipe1.Rows.Clear();
            dgvEquipe2.Rows.Clear();
            foreach (Joueur joueur in equipe1.Joueurs)
            {
                dgvEquipe1.Rows.Add();
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[0].Value = joueur.Nom;
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[1].Value = joueur.Prenom;
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[2].Value = joueur.Poids;
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[3].Value = joueur.Annee_dAdhesion;
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[4].Value = joueur.Arme;
                dgvEquipe1.Rows[dgvEquipe1.Rows.Count - 1].Cells[5].Value = joueur.Armure;
            }

            foreach (Joueur joueur in equipe2.Joueurs)
            {
                dgvEquipe2.Rows.Add();
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[0].Value = joueur.Nom;
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[1].Value = joueur.Prenom;
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[2].Value = joueur.Poids;
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[3].Value = joueur.Annee_dAdhesion;
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[4].Value = joueur.Arme;
                dgvEquipe2.Rows[dgvEquipe2.Rows.Count - 1].Cells[5].Value = joueur.Armure;
            }
        }

    }
}
