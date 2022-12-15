
namespace projet_Fulbank
{
    partial class Conversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.nbcrypto = new System.Windows.Forms.Label();
            this.amountAfter = new System.Windows.Forms.TextBox();
            this.somme = new System.Windows.Forms.Label();
            this.nomcrypto = new System.Windows.Forms.Label();
            this.nbConvert = new System.Windows.Forms.TextBox();
            this.convertir = new System.Windows.Forms.Button();
            this.lstCrypto = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "N° de compte :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Nom :";
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
            this.retour.TabIndex = 24;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.titre.Location = new System.Drawing.Point(278, 139);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(233, 52);
            this.titre.TabIndex = 25;
            this.titre.Text = "Conversion";
            // 
            // nbcrypto
            // 
            this.nbcrypto.AutoSize = true;
            this.nbcrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbcrypto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.nbcrypto.Location = new System.Drawing.Point(6, 213);
            this.nbcrypto.Name = "nbcrypto";
            this.nbcrypto.Size = new System.Drawing.Size(385, 24);
            this.nbcrypto.TabIndex = 26;
            this.nbcrypto.Text = "Nombre de cryptomonnaies à convertir :";
            // 
            // amountAfter
            // 
            this.amountAfter.Enabled = false;
            this.amountAfter.Location = new System.Drawing.Point(119, 354);
            this.amountAfter.Name = "amountAfter";
            this.amountAfter.Size = new System.Drawing.Size(143, 20);
            this.amountAfter.TabIndex = 28;
            // 
            // somme
            // 
            this.somme.AutoSize = true;
            this.somme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.somme.Location = new System.Drawing.Point(60, 327);
            this.somme.Name = "somme";
            this.somme.Size = new System.Drawing.Size(260, 24);
            this.somme.TabIndex = 29;
            this.somme.Text = "Somme après conversion :";
            // 
            // nomcrypto
            // 
            this.nomcrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomcrypto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.nomcrypto.Location = new System.Drawing.Point(492, 213);
            this.nomcrypto.Name = "nomcrypto";
            this.nomcrypto.Size = new System.Drawing.Size(272, 23);
            this.nomcrypto.TabIndex = 30;
            this.nomcrypto.Text = "Nom de la cryptomonnaie :";
            // 
            // nbConvert
            // 
            this.nbConvert.Location = new System.Drawing.Point(119, 240);
            this.nbConvert.Name = "nbConvert";
            this.nbConvert.Size = new System.Drawing.Size(143, 20);
            this.nbConvert.TabIndex = 31;
            this.nbConvert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertir
            // 
            this.convertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.convertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertir.FlatAppearance.BorderSize = 0;
            this.convertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertir.ForeColor = System.Drawing.Color.White;
            this.convertir.Location = new System.Drawing.Point(558, 341);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(110, 33);
            this.convertir.TabIndex = 34;
            this.convertir.Text = "Convertir";
            this.convertir.UseVisualStyleBackColor = false;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // lstCrypto
            // 
            this.lstCrypto.FormattingEnabled = true;
            this.lstCrypto.Location = new System.Drawing.Point(540, 240);
            this.lstCrypto.Name = "lstCrypto";
            this.lstCrypto.Size = new System.Drawing.Size(143, 21);
            this.lstCrypto.TabIndex = 35;
            this.lstCrypto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(528, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 60);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "La conversion des cryptomonnaies est effectué sur le compte courant du titulaire";
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCrypto);
            this.Controls.Add(this.convertir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nbConvert);
            this.Controls.Add(this.nomcrypto);
            this.Controls.Add(this.somme);
            this.Controls.Add(this.amountAfter);
            this.Controls.Add(this.nbcrypto);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.logo);
            this.Name = "Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label nbcrypto;
        private System.Windows.Forms.TextBox amountAfter;
        private System.Windows.Forms.Label somme;
        private System.Windows.Forms.Label nomcrypto;
        private System.Windows.Forms.TextBox nbConvert;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button convertir;
        private System.Windows.Forms.ComboBox lstCrypto;
        private System.Windows.Forms.Label label1;
    }
}