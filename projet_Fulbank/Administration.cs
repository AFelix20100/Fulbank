using projet_Fulbank.Class;
using projet_Fulbank.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                tabAccount.Rows.Add(unUser.getId(), unUser.getLastName(), unUser.getFirstName(), unUser.getMail(), unUser.getNumber(), unUser.getAdress(), unUser.getCp(), unUser.getCity(), unUser.getCountry(), unUser.getLogin(), unUser.getPassword(), unUser.getType());
            }

            foreach (User unUser in AdministationManager.getAllUsers())
            {
                tabAccountHistorical.Rows.Add(unUser.getId(), unUser.getLastName(), unUser.getFirstName());
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

                //string id = tabAccount.Rows[tabAccount.CurrentCell.RowIndex].Cells[0].Value.ToString();
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
                    string id = unR.Cells[0].Value.ToString();
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
    }
}
