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
            this.logo = new System.Windows.Forms.PictureBox();
            this.identifiant_label = new System.Windows.Forms.Label();
            this.mot_de_passe_label = new System.Windows.Forms.Label();
            this.identifiant_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.connexion_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.identifiant_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.identifiant_label.Location = new System.Drawing.Point(229, 252);
            this.identifiant_label.Name = "identifiant_label";
            this.identifiant_label.Size = new System.Drawing.Size(92, 20);
            this.identifiant_label.TabIndex = 3;
            this.identifiant_label.Text = "Identifiant : ";
            this.identifiant_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // mot_de_passe_label
            // 
            this.mot_de_passe_label.AutoSize = true;
            this.mot_de_passe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mot_de_passe_label.Location = new System.Drawing.Point(229, 294);
            this.mot_de_passe_label.Name = "mot_de_passe_label";
            this.mot_de_passe_label.Size = new System.Drawing.Size(113, 20);
            this.mot_de_passe_label.TabIndex = 4;
            this.mot_de_passe_label.Text = "Mot de passe :";
            // 
            // identifiant_textbox
            // 
            this.identifiant_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.identifiant_textbox.Location = new System.Drawing.Point(348, 249);
            this.identifiant_textbox.Name = "identifiant_textbox";
            this.identifiant_textbox.Size = new System.Drawing.Size(166, 26);
            this.identifiant_textbox.TabIndex = 5;
            this.identifiant_textbox.TextChanged += new System.EventHandler(this.identifiant_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password_textbox.Location = new System.Drawing.Point(348, 294);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(166, 26);
            this.password_textbox.TabIndex = 6;
            this.password_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // connexion_button
            // 
            this.connexion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.connexion_button.Location = new System.Drawing.Point(280, 361);
            this.connexion_button.Name = "connexion_button";
            this.connexion_button.Size = new System.Drawing.Size(165, 69);
            this.connexion_button.TabIndex = 7;
            this.connexion_button.Text = "Se connecter";
            this.connexion_button.UseVisualStyleBackColor = true;
            this.connexion_button.Click += new System.EventHandler(this.connexion_button_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.connexion_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.identifiant_textbox);
            this.Controls.Add(this.mot_de_passe_label);
            this.Controls.Add(this.identifiant_label);
            this.Controls.Add(this.logo);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label identifiant_label;
        private System.Windows.Forms.Label mot_de_passe_label;
        private System.Windows.Forms.TextBox identifiant_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button connexion_button;
    }
}