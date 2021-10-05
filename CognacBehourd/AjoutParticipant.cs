using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognacBehourd
{
    public partial class AjoutParticipant : Form
    {
        public AjoutParticipant()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            /*List<Joueur> joueurs = new List<Joueur>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                joueurs.Add(new Joueur(
                    (String)row.Cells[0].Value,
                    (String)row.Cells[1].Value, 
                    (int)row.Cells[2].Value, 
                    (int)row.Cells[3].Value, 
                    (String)row.Cells[4].Value, 
                    (String)row.Cells[5].Value));
            }
            ((MainForm)this.Parent).joueurs = joueurs;
            this.Close();*/
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
