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
    public partial class Virement : Form
    {
        public Virement()
        {
            InitializeComponent();
        }

        private void retour_Click(object sender, EventArgs e)
        {

            this.Hide();
            var menu = new Menu();
            menu.Show();
        }
    }
}
