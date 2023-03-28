using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_Fulbank
{
    public partial class Virement : Form
    {
        Menu menu;
        MySqlConnection pdo = DBConnexion.getConnexion();
        MySqlDataReader reader;
        MySqlCommand command;
        public string lastName;
        public string accountNumber;
        public int SoldAfterSum;
        public Virement()
        {
            InitializeComponent();

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void TransfertSum_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Virement_Load(object sender, EventArgs e)
        {
            VirementLastName.Text = Connexion.lastName;
            VirementAccountNumber.Text = Connexion.accountNumber.ToString();
        }

        private void beneficiary_Click(object sender, EventArgs e)
        {
            this.Hide();
            var beneficiaire = new Beneficiare();
            beneficiaire.Show();
        }
        private void transfert_Click(object sender, EventArgs e)
        {
            
            
            if (deb_current.Checked == true && cred_current.Checked == true)
            {
                MessageBox.Show("Cette action est impossible");
            }
            else if (deb_booklet.Checked == true && cred_booklet.Checked == true)
            {
                MessageBox.Show("Cette action est impossible");
            }
            else if (deb_current.Checked == true && cred_booklet.Checked == true)
            {
                double anAmount = Convert.ToInt32(TransfertSum.Text.Trim());
                OperationManager.TransferAddSavings(Convert.ToDouble(TransfertSum.Text));
                OperationManager.TransferWithdrawCurrent(Convert.ToDouble(TransfertSum.Text));
                OperationManager.OperationTransferCurrentToSavings(anAmount);
                MessageBox.Show("Le virement a bien été effectué");
            }
            else if (deb_booklet.Checked == true && cred_current.Checked == true)
            {
                OperationManager.TransferWithdrawSavings(Convert.ToDouble(TransfertSum.Text));
                OperationManager.TransferAddCurrent(Convert.ToDouble(TransfertSum.Text));
                OperationManager.OperationTransferSavingsToCurrent(Convert.ToDouble(TransfertSum.Text));
                MessageBox.Show("Le virement a bien été effectué");
            }
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void deb_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deb_booklet_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void cred_current_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
        

