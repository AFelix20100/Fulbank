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
    public partial class Beneficiare : Form
    {
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
            BeneficiaryLastName.Text = Connexion.lastName;
            BeneficiaryAccountNumber.Text = Connexion.accountNumber.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void iban_beneficiaire_TextChanged(object sender, EventArgs e)
        {
            if (iban_beneficiaire.Text == "")
            {
                MessageBox.Show("Veuillez saisir un Iban");
            }
        }

        private void dataGridViewExternalBeneficiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameBeneficiary_TextChanged(object sender, EventArgs e)
        {
            if (NameBeneficiary.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom");
            }
        }
    }
}
