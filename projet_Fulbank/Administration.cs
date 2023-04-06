using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_Fulbank
{

    public partial class Administration : Form
    {
        public string lastName;
        public string accountNumber;
        public Administration()
        {
            InitializeComponent();
            
        }

        private void historique_Paint(object sender, PaintEventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compte.Hide();
            historique.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compte.Show();
        }

        private void compte_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Administration_Load(object sender, EventArgs e)
        {
            foreach (User unUser in AdministationManager.getAllUsers())
            {
                tabAccount.Rows.Add(unUser.getId(), unUser.getLastName(), unUser.getFirstName(), unUser.getMail(), unUser.getNumber(), unUser.getAdress(), unUser.getCp(), unUser.getCity(), unUser.getCountry(), unUser.getLogin(), unUser.getType());
            }

            foreach (User unUser in AdministationManager.getAllUsers())
            {
                tabAccountHistorical.Rows.Add(unUser.getId(), unUser.getLastName(), unUser.getFirstName(),unUser.getLogin());
            }

        }

        private void create_Click(object sender, EventArgs e)
        {

        }

        private void AdminMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tabAccount.Update();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {

            if (tabAccount.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez chosir qu'une personne");
            }
            else
            {
                string lastName = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string firstName = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string mail = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[3].Value.ToString();
                double phone = Convert.ToDouble(tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[4].Value.ToString());
                string address = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[5].Value.ToString();
                int zipcode = Convert.ToInt32(tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[6].Value.ToString());
                string city = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[7].Value.ToString();
                string country = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[8].Value.ToString();
                AdministationManager.insertOne(lastName, firstName, mail, phone, address, zipcode, city, country, 1); 
            }


            tabAccountHistorical.Rows.Clear();

            tabAccount.Rows.Clear();
            tabAccount.Refresh();
            Administration_Load(sender, e);
        }



        private void removeUser_Click(object sender, EventArgs e)
        {
            /*
            Int32 selectedCellCount = tabAccount.GetCellCount(DataGridViewElementStates.Selected);
            for(int i = 0; i < selectedCellCount; i++)
            {
                MessageBox.Show(tabAccount.SelectedCells[i].Value.ToString());
            }*/

            if (tabAccount.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez chosir qu'une personne");
            }
            else
            {

                foreach (DataGridViewRow unR in tabAccount.SelectedRows)
                {
                    int id = int.Parse(unR.Cells[0].Value.ToString());
                    if (MessageBox.Show("Voulez-vous vraiment supprimer l'utilisateur qui a pour ID : " + id, "Validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AdministationManager.removeUserById(id);
                        MessageBox.Show("L'utilisateur qui a pour id : " + id + " a été supprimé.");
                    }
                }

            }
            tabAccount.Rows.Clear();
            tabAccount.Refresh();
            Administration_Load(sender, e);
            ///string unNom = unR[0];
        }

        private void tabAccountHistorical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabAccount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabAccount_CurrentCellChanged(object sender, EventArgs e)
        {
            //TO DO REGEX on phone field
            /*
            string phone = tabAccount.CurrentRow.Cells[4].Value.ToString();

            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(phone))
            {
                tabAccount.CurrentCell.Style.ForeColor = Color.Black;
            }
            else
            {
                tabAccount.CurrentCell.Style.ForeColor = Color.Red;
            }
            */
        }

        private void tabAccount_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*
            string pattern = @"/^((\\+|00)33\\s?|0)[67](\\s?\\d{2}){4}$/";
            string input = tabAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if(!Regex.IsMatch(input,pattern))
            {
                MessageBox.Show("test");
            }*/
        }

        private void tabAccount_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            
        }

        private void tabAccount_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (this.tabAccount.CurrentCell.ColumnIndex == 4)
            {
                string phone = tabAccount.CurrentRow.Cells[4].Value.ToString();
                if (tabAccount.CurrentCell.ColumnIndex == 4)
                {

                    if ((new Regex(@"^[A-Za-z]+$")).IsMatch(phone))
                    {
                        tabAccount.CurrentCell.Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        tabAccount.CurrentCell.Style.ForeColor = Color.Red;
                    }

                }
            }
            */
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            if (tabAccount.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez chosir qu'une personne");
            }
            else
            {
                foreach (DataGridViewRow unR in tabAccount.SelectedRows)
                {
                    int id = int.Parse(unR.Cells[0].Value.ToString());
                    string firstName = unR.Cells[1].Value.ToString();
                    string lastName = unR.Cells[2].Value.ToString();
                    string mail = unR.Cells[3].Value.ToString();
                    double phone = Convert.ToDouble(unR.Cells[4].Value);
                    string address = unR.Cells[5].Value.ToString();
                    int zipCode = Convert.ToInt32(unR.Cells[6].Value);
                    string city = unR.Cells[7].Value.ToString();
                    string country = unR.Cells[8].Value.ToString();
                    string password = unR.Cells[10].Value.ToString();
                    int aType = int.Parse(unR.Cells[11].Value.ToString());

                    if (MessageBox.Show("Voulez-vous vraiment mettre à jour l'utilisateur qui a pour ID : " + id, "Validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if(MessageBox.Show("Voulez-vous changer le mot de passe de l'utilisateur qui a pour ID : " + id, "Validation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            AccountManager.setPassword(id);
                        }
                        AdministationManager.modifyUserById(id,firstName,lastName,mail,phone,address,zipCode,city,country,aType);
                        MessageBox.Show("L'utilisateur qui a pour id : " + id + " a été modifié.");
                    }
                }
            }
            tabAccountHistorical.Rows.Clear();
            tabAccount.Refresh();
            tabAccount.Rows.Clear();
            tabAccount.Refresh();
            Administration_Load(sender, e);
        }

        private void tabAccountHistorical_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tabAccountHistorical_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountListTab.Rows.Clear();
            if (tabAccountHistorical.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez chosir qu'une personne");
            }
            else
            {
                //TO DO il faut faire une méthode getDetailIUser qui va nous retourner un User.
                //Ensuite avec la POO je fait le nom de la méthode.GetCurrent() ce qui me retourne une collection de Current et mm chose pour savings
                //Pour afficher la liste de ses comptes il suffit de changer la couleur de fond pour différencer
                
                foreach (DataGridViewRow unR in tabAccountHistorical.SelectedRows)
                {
                    long login = long.Parse(unR.Cells[3].Value.ToString());
                    User unUser = UserManager.FindByLogin(login);
                    AccountManager.makeAccount(unUser);

                    foreach (Current aCurrent in unUser.getAllCurrent())
                    {
                        //accountListTab.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        accountListTab.Rows.Add(aCurrent.getId(), aCurrent.getIban(), aCurrent.getBic(), aCurrent.getSolde(), aCurrent.getDebt(), aCurrent.getLimit(), aCurrent.getIdPerson(),aCurrent.getTypeOfAccount());
                    }

                    foreach (Savings aSaving in unUser.getAllSavings())
                    {
                        //accountListTab.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        accountListTab.Rows.Add(aSaving.getId(), aSaving.getIban(), aSaving.getBic(), aSaving.getSolde(), aSaving.getDebt(), aSaving.getLimit(), aSaving.getIdPerson(), aSaving.getTypeOfAccount());
                    }

                }

            }
        }
    }
}
