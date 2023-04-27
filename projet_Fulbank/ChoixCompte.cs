using projet_Fulbank.Class.Model;
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
    public partial class ChoixCompte : Form
    {
        public ChoixCompte()
        {
            InitializeComponent();
        }

        private void ChoixCompte_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = UserManager.FindByLogin(Convert.ToInt32(label14.Text));
            Releve releve = new Releve(OperationManager.GetOperationsByLogin(user.getLogin(),1));
            releve.Show();
        }

        private void button2btn_compte_epargne_Click(object sender, EventArgs e)
        {
            User user = UserManager.FindByLogin(Convert.ToInt32(label14.Text));
            Releve releve = new Releve(OperationManager.GetOperationsByLogin(user.getLogin(),2));
            releve.Show();
        }
    }
}
