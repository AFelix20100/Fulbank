﻿using System;
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
    public partial class Achat_de_cryptomonnaies1 : Form
    {
        public Achat_de_cryptomonnaies1()
        {
            InitializeComponent();
        }

        private void Achat_de_cryptomonnaies1_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.lastName;
            label14.Text = Connexion.accountNumber.ToString();
            var listeCryptocrurrencies = AppelHTTPS.RequeteHTTPS();
            foreach(var currency in listeCryptocrurrencies.data)
            {
                typecrypto.Items.Add(currency.name);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
