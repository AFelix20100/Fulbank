using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void historique_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compte.Hide();
            historique.Show();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historique.Hide();
            compte.Show();
        }

        private void compte_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
