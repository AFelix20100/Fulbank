using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    public partial class PrixCrypto : Form
    {
        public PrixCrypto()
        {
            InitializeComponent();
        }

        private void PrixCrypto_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            string path = "";
            List<PictureBox> LogoList = new List<PictureBox>() { logo0, logo1, logo2 };
            foreach (PictureBox pic in LogoList)
            { 
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
       
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }
    }
}
