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
            this.Hide();
            ChoixCompte choixCompte = new ChoixCompte();
            choixCompte.Show();
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
            DataGridViewReleve.EnableHeadersVisualStyles = false;
            DataGridViewReleve.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;

            //Chargement des données dans le datagridview.

            foreach (Operation oneOperation in _lesOperations)
            {
                MessageBox.Show(oneOperation.getAmount().ToString());
                if (oneOperation.getAmount() < 0)
                {
                    DataGridViewReleve.Rows.Add(oneOperation.getDate(), oneOperation.getDescription(), oneOperation.getAmount());
                }
                else
                {
                    DataGridViewReleve.Rows.Add(oneOperation.getDate(), oneOperation.getDescription(), null, "+" + oneOperation.getAmount());
                }
            }
        }

        private void DataGridViewReleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
