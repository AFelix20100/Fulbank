namespace projet_Fulbank
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.logo = new System.Windows.Forms.PictureBox();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.mot_de_passe_label = new System.Windows.Forms.Label();
            this.identifiant_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.connexion_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(140, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // identifiant_label
            // 
            this.identifiant_label.AutoSize = true;
            this.identifiant_label.BackColor = System.Drawing.Color.White;
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.identifiant_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(31)))));
            this.identifiant_label.Location = new System.Drawing.Point(190, 260);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(106, 20);
            this.identifiant_label.TabIndex = 3;
            this.identifiant_label.Text = "Identifiant : ";
            this.identifiant_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // mot_de_passe_label
            // 
            this.mot_de_passe_label.AutoSize = true;
            this.mot_de_passe_label.BackColor = System.Drawing.Color.White;
            this.mot_de_passe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mot_de_passe_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(31)))));
            this.mot_de_passe_label.Location = new System.Drawing.Point(190, 318);
            this.mot_de_passe_label.Name = "mot_de_passe_label";
            this.mot_de_passe_label.Size = new System.Drawing.Size(127, 20);
            this.mot_de_passe_label.TabIndex = 4;
            this.mot_de_passe_label.Text = "Mot de passe :";
            // 
            // identifiant_textbox
            // 
            this.identifiant_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.identifiant_textbox.Location = new System.Drawing.Point(192, 283);
            this.identifiant_textbox.Name = "identifiant_textbox";
            this.identifiant_textbox.Size = new System.Drawing.Size(166, 26);
            this.identifiant_textbox.TabIndex = 5;
            this.identifiant_textbox.TextChanged += new System.EventHandler(this.identifiant_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_textbox.Location = new System.Drawing.Point(191, 341);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(167, 26);
            this.password_textbox.TabIndex = 6;
            this.password_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connexion_button
            // 
            this.connexion_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(31)))));
            this.connexion_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connexion_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(31)))));
            this.connexion_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.connexion_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.connexion_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.connexion_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connexion_button.Location = new System.Drawing.Point(218, 425);
            this.connexion_button.Name = "connexion_button";
            this.connexion_button.Size = new System.Drawing.Size(115, 30);
            this.connexion_button.TabIndex = 7;
            this.connexion_button.Text = "Se connecter";
            this.connexion_button.UseVisualStyleBackColor = false;
            this.connexion_button.Click += new System.EventHandler(this.connexion_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.connexion_button);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.mot_de_passe_label);
            this.panel1.Controls.Add(this.identifiant_textbox);
            this.panel1.Controls.Add(this.identifiant_label);
            this.panel1.Location = new System.Drawing.Point(125, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 564);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(204, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.Label mot_de_passe_label;
        private System.Windows.Forms.TextBox identifiant_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button connexion_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}