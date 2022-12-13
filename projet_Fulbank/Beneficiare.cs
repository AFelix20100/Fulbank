using MySql.Data.MySqlClient;
using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_Fulbank
{
    public partial class Beneficiare : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public Beneficiare()
        {
            InitializeComponent();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var virement = new Virement();
            virement.Show();
        }

        private void Beneficiare_Load(object sender, EventArgs e)
        {
            VirementNom.Text = Connexion.lastName;
            VirementNumCompte.Text = Connexion.accountNumber.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseBenefit.Items.Insert(0,iban_beneficiaire.Text);
            
            
        }

        private void virer_Click(object sender, EventArgs e)
        {
            OperationManager.TransfertIntoBeneficiary(Convert.ToDouble(TransfertSum.Text), chooseBenefit.SelectedItem.ToString());
            MessageBox.Show("Votre virement à bien été effectuer");
        }
    }
}
