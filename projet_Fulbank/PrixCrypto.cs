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
using projet_Fulbank.Class;

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
            logo0.SizeMode = PictureBoxSizeMode.StretchImage;
            logo1.SizeMode = PictureBoxSizeMode.StretchImage;
            logo2.SizeMode = PictureBoxSizeMode.StretchImage;
            Root PrixCrypto = AppelHTTPS.RequeteHTTPS();
            prix0.Text = PrixCrypto.data[0].priceUsd.ToString();
            prix1.Text = PrixCrypto.data[1].priceUsd.ToString();
            prix2.Text = PrixCrypto.data[2].priceUsd.ToString();

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
