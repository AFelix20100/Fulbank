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
            foreach(User unUser in AdministationManager.getAllUsers())
            {
                tabAccount.Rows.Add(unUser.getId(),unUser.getLastName(),unUser.getFirstName(),unUser.getMail(),unUser.getNumber(),unUser.getAdress(),unUser.getCp(),unUser.getCity(),unUser.getCountry(),unUser.getType());
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

        }

        private void delete_Click(object sender, EventArgs e)
        {
            /*
            Int32 selectedCellCount = tabAccount.GetCellCount(DataGridViewElementStates.Selected);
            for(int i = 0; i < selectedCellCount; i++)
            {
                MessageBox.Show(tabAccount.SelectedCells[i].Value.ToString());
            }*/
            if(tabAccount.SelectedRows.Count>1)
            {
                MessageBox.Show("veuillez chosir qu'une personne");
            }
            else
            {
                foreach (DataGridViewRow unR in tabAccount.SelectedRows)
                {
                    string id = unR.Cells[0].Value.ToString();
                    AdministationManager.removeUserById(id);
                    MessageBox.Show("L'utilisateur qui a pour id :" + id + "a été supprimé.");
                }
            }
            tabAccount.Rows.Clear();
            tabAccount.Refresh();
            Administration_Load(sender,e);
            ///string unNom = unR[0];
        }
    }
}
