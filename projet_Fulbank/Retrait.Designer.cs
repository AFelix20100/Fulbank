
namespace projet_Fulbank
{
    partial class Retrait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retrait));
            this.titre = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.retirer = new System.Windows.Forms.Button();
            this.SoldText = new System.Windows.Forms.TextBox();
            this.debit = new System.Windows.Forms.Label();
            this.retrait_somme = new System.Windows.Forms.Label();
            this.SoldAfterText = new System.Windows.Forms.TextBox();
            this.solde_compte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DebiteSumText = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.titre.Location = new System.Drawing.Point(321, 139);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(148, 52);
            this.titre.TabIndex = 31;
            this.titre.Text = "Retrait";
            this.titre.Click += new System.EventHandler(this.titre_Click);
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
            this.retour.TabIndex = 30;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(12, 24);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(88, 15);
            this.accountNumberLabel.TabIndex = 28;
            this.accountNumberLabel.Text = "N° de compte :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(12, 9);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(40, 15);
            this.lastNameLabel.TabIndex = 27;
            this.lastNameLabel.Text = "Nom :";
            // 
            // retirer
            // 
            this.retirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.retirer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retirer.FlatAppearance.BorderSize = 0;
            this.retirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirer.ForeColor = System.Drawing.Color.White;
            this.retirer.Location = new System.Drawing.Point(564, 338);
            this.retirer.Name = "retirer";
            this.retirer.Size = new System.Drawing.Size(110, 33);
            this.retirer.TabIndex = 42;
            this.retirer.Text = "Retirer";
            this.retirer.UseVisualStyleBackColor = false;
            // 
            // SoldText
            // 
            this.SoldText.Enabled = false;
            this.SoldText.Location = new System.Drawing.Point(125, 237);
            this.SoldText.Name = "SoldText";
            this.SoldText.Size = new System.Drawing.Size(143, 20);
            this.SoldText.TabIndex = 40;
            this.SoldText.TextChanged += new System.EventHandler(this.SoldText_TextChanged);
            // 
            // debit
            // 
            this.debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.debit.Location = new System.Drawing.Point(530, 210);
            this.debit.Name = "debit";
            this.debit.Size = new System.Drawing.Size(185, 23);
            this.debit.TabIndex = 39;
            this.debit.Text = "Somme à débiter :";
            // 
            // retrait_somme
            // 
            this.retrait_somme.AutoSize = true;
            this.retrait_somme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrait_somme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.retrait_somme.Location = new System.Drawing.Point(109, 324);
            this.retrait_somme.Name = "retrait_somme";
            this.retrait_somme.Size = new System.Drawing.Size(192, 24);
            this.retrait_somme.TabIndex = 38;
            this.retrait_somme.Text = "Solde après retrait :";
            // 
            // SoldAfterText
            // 
            this.SoldAfterText.Location = new System.Drawing.Point(125, 351);
            this.SoldAfterText.Name = "SoldAfterText";
            this.SoldAfterText.Size = new System.Drawing.Size(143, 20);
            this.SoldAfterText.TabIndex = 37;
            this.SoldAfterText.TextChanged += new System.EventHandler(this.SoldAfterText_TextChanged);
            // 
            // solde_compte
            // 
            this.solde_compte.AutoSize = true;
            this.solde_compte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde_compte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.solde_compte.Location = new System.Drawing.Point(109, 210);
            this.solde_compte.Name = "solde_compte";
            this.solde_compte.Size = new System.Drawing.Size(181, 24);
            this.solde_compte.TabIndex = 36;
            this.solde_compte.Text = "Solde du compte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 9);
            this.label1.TabIndex = 44;
            this.label1.Text = "Le retrait est effectué sur le compte courant du titulaire";
            // 
            // DebiteSumText
            // 
            this.DebiteSumText.Location = new System.Drawing.Point(546, 237);
            this.DebiteSumText.Name = "DebiteSumText";
            this.DebiteSumText.Size = new System.Drawing.Size(143, 20);
            this.DebiteSumText.TabIndex = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(534, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 60);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // Retrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DebiteSumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retirer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SoldText);
            this.Controls.Add(this.debit);
            this.Controls.Add(this.retrait_somme);
            this.Controls.Add(this.SoldAfterText);
            this.Controls.Add(this.solde_compte);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.logo);
            this.Name = "Retrait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retrait";
            this.Load += new System.EventHandler(this.Retrait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button retirer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox SoldText;
        private System.Windows.Forms.Label debit;
        private System.Windows.Forms.Label retrait_somme;
        private System.Windows.Forms.TextBox SoldAfterText;
        private System.Windows.Forms.Label solde_compte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DebiteSumText;
    }
}