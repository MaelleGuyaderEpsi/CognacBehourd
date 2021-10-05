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
    public partial class MainForm : Form
    {
        public List<Joueur> joueurs { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutParticipant objUI = new AjoutParticipant();
            objUI.ShowInTaskbar = true;
            objUI.Show();
        }

        private void Start_Click(object sender, EventArgs e)
        {
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
        }


    }
}
