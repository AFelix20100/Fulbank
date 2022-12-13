namespace projet_Fulbank
{
    partial class Beneficiare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beneficiare));
            this.titre = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.VirementNumCompte = new System.Windows.Forms.Label();
            this.VirementNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iban_beneficiaire = new System.Windows.Forms.TextBox();
            this.virer = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.addIban = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chooseBenefit = new System.Windows.Forms.ComboBox();
            this.TransfertSum = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.titre.Location = new System.Drawing.Point(296, 139);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(202, 52);
            this.titre.TabIndex = 57;
            this.titre.Text = "Virement";
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.ForeColor = System.Drawing.Color.White;
            this.retour.Location = new System.Drawing.Point(12, 102);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(98, 23);
            this.retour.TabIndex = 56;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // VirementNumCompte
            // 
            this.VirementNumCompte.AutoSize = true;
            this.VirementNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementNumCompte.Location = new System.Drawing.Point(12, 24);
            this.VirementNumCompte.Name = "VirementNumCompte";
            this.VirementNumCompte.Size = new System.Drawing.Size(88, 15);
            this.VirementNumCompte.TabIndex = 54;
            this.VirementNumCompte.Text = "N° de compte :";
            // 
            // VirementNom
            // 
            this.VirementNom.AutoSize = true;
            this.VirementNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementNom.Location = new System.Drawing.Point(12, 9);
            this.VirementNom.Name = "VirementNom";
            this.VirementNom.Size = new System.Drawing.Size(40, 15);
            this.VirementNom.TabIndex = 53;
            this.VirementNom.Text = "Nom :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 52;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(324, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Autre bénéficiaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(3, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Iban du bénéficiaire";
            // 
            // iban_beneficiaire
            // 
            this.iban_beneficiaire.Location = new System.Drawing.Point(3, 453);
            this.iban_beneficiaire.Name = "iban_beneficiaire";
            this.iban_beneficiaire.Size = new System.Drawing.Size(233, 20);
            this.iban_beneficiaire.TabIndex = 60;
            // 
            // virer
            // 
            this.virer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.virer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.virer.FlatAppearance.BorderSize = 0;
            this.virer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virer.ForeColor = System.Drawing.Color.White;
            this.virer.Location = new System.Drawing.Point(587, 467);
            this.virer.Name = "virer";
            this.virer.Size = new System.Drawing.Size(110, 33);
            this.virer.TabIndex = 62;
            this.virer.Text = "Valider";
            this.virer.UseVisualStyleBackColor = false;
            this.virer.Click += new System.EventHandler(this.virer_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(560, 453);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 60);
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // addIban
            // 
            this.addIban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.addIban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIban.FlatAppearance.BorderSize = 0;
            this.addIban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIban.ForeColor = System.Drawing.Color.White;
            this.addIban.Location = new System.Drawing.Point(12, 490);
            this.addIban.Name = "addIban";
            this.addIban.Size = new System.Drawing.Size(98, 23);
            this.addIban.TabIndex = 64;
            this.addIban.Text = "Ajouter";
            this.addIban.UseVisualStyleBackColor = false;
            this.addIban.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 44);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // chooseBenefit
            // 
            this.chooseBenefit.FormattingEnabled = true;
            this.chooseBenefit.Location = new System.Drawing.Point(12, 229);
            this.chooseBenefit.Name = "chooseBenefit";
            this.chooseBenefit.Size = new System.Drawing.Size(222, 21);
            this.chooseBenefit.TabIndex = 65;
            this.chooseBenefit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TransfertSum
            // 
            this.TransfertSum.BackColor = System.Drawing.SystemColors.Window;
            this.TransfertSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TransfertSum.Location = new System.Drawing.Point(12, 353);
            this.TransfertSum.Name = "TransfertSum";
            this.TransfertSum.Size = new System.Drawing.Size(155, 20);
            this.TransfertSum.TabIndex = 66;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Sum.Location = new System.Drawing.Point(12, 321);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(158, 18);
            this.Sum.TabIndex = 67;
            this.Sum.Text = "Somme du virement";
            // 
            // test
            // 
            this.test.Enabled = false;
            this.test.Location = new System.Drawing.Point(362, 353);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(359, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Solde après virement";
            // 
            // Beneficiare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.TransfertSum);
            this.Controls.Add(this.chooseBenefit);
            this.Controls.Add(this.addIban);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.virer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.iban_beneficiaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VirementNumCompte);
            this.Controls.Add(this.VirementNom);
            this.Controls.Add(this.logo);
            this.Name = "Beneficiare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiare";
            this.Load += new System.EventHandler(this.Beneficiare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label VirementNumCompte;
        private System.Windows.Forms.Label VirementNom;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iban_beneficiaire;
        private System.Windows.Forms.Button virer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button addIban;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox chooseBenefit;
        private System.Windows.Forms.TextBox TransfertSum;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.TextBox test;
        private System.Windows.Forms.Label label3;
    }
}