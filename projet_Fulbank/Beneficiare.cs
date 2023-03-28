using Newtonsoft.Json.Linq;
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
            ExternalTransfer.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (iban_beneficiaire.Text == "")
            {
                MessageBox.Show("Veuillez saisir un Iban");
            }
            if (NameBeneficiary.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom");
            }

            string Nom = NameBeneficiary.Text;
            string Iban = iban_beneficiaire.Text;
            dataGridViewExternalBeneficiary.Rows.Add(Nom, Iban);


        } 

        private void iban_beneficiaire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewExternalBeneficiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameBeneficiary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void transfertExternal_Click(object sender, EventArgs e)
        {
            if (dataGridViewExternalBeneficiary.SelectedRows.Count == 0) {
                MessageBox.Show("Veuillez choisir une personne");
            }
            if (dataGridViewExternalBeneficiary.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez chosir qu'une personne");
            }
            else if (dataGridViewExternalBeneficiary.SelectedRows.Count == 1)
            {
                ExternalTransfer.Show();
                DataGridViewCell cell = dataGridViewExternalBeneficiary.SelectedRows[0].Cells[0];

                string Nom = cell.Value.ToString();
                externalBeneficiairy.Text = Nom ;
            }
        }

        private void transfer_amount_Click(object sender, EventArgs e)
        {

        }

        private void ExternalTransfer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
