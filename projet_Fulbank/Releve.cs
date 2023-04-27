using projet_Fulbank.Class;
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
    public partial class Releve : Form
    {
        public List<Operation> _lesOperations;
        public Releve(List<Operation> lesOperations)
        {
            InitializeComponent();
            _lesOperations = lesOperations;
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void Releve_Load(object sender, EventArgs e)
        {
            DataGridViewReleve.Rows[0].DefaultCellStyle.BackColor = Color.Azure;
        }
    }
}
