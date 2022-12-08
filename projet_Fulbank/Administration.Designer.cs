namespace projet_Fulbank
{
    partial class Administration
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
            this.tabhistory = new System.Windows.Forms.DataGridView();
            this.historique = new System.Windows.Forms.Panel();
            this.tabclient = new System.Windows.Forms.DataGridView();
            this.TitleHistory = new System.Windows.Forms.Label();
            this.compte = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.removeUser = new System.Windows.Forms.PictureBox();
            this.addUser = new System.Windows.Forms.PictureBox();
            this.tabAccount = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotDePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreAccount = new System.Windows.Forms.Label();
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAccountHistorical = new System.Windows.Forms.DataGridView();
            this.idClientHistorical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameClientHistorical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameClientHistorical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabhistory)).BeginInit();
            this.historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).BeginInit();
            this.compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).BeginInit();
            this.AdminMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccountHistorical)).BeginInit();
            this.SuspendLayout();
            // 
            // tabhistory
            // 
            this.tabhistory.BackgroundColor = System.Drawing.Color.White;
            this.tabhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabhistory.Location = new System.Drawing.Point(83, 256);
            this.tabhistory.Name = "tabhistory";
            this.tabhistory.Size = new System.Drawing.Size(601, 263);
            this.tabhistory.TabIndex = 1;
            // 
            // historique
            // 
            this.historique.Controls.Add(this.tabAccountHistorical);
            this.historique.Controls.Add(this.tabclient);
            this.historique.Controls.Add(this.TitleHistory);
            this.historique.Controls.Add(this.tabhistory);
            this.historique.Location = new System.Drawing.Point(13, 27);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(759, 522);
            this.historique.TabIndex = 2;
            this.historique.Paint += new System.Windows.Forms.PaintEventHandler(this.historique_Paint);
            // 
            // tabclient
            // 
            this.tabclient.BackgroundColor = System.Drawing.Color.White;
            this.tabclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabclient.GridColor = System.Drawing.Color.Black;
            this.tabclient.Location = new System.Drawing.Point(3, 100);
            this.tabclient.Name = "tabclient";
            this.tabclient.Size = new System.Drawing.Size(240, 150);
            this.tabclient.TabIndex = 3;
            // 
            // TitleHistory
            // 
            this.TitleHistory.AutoSize = true;
            this.TitleHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TitleHistory.Location = new System.Drawing.Point(289, 9);
            this.TitleHistory.Name = "TitleHistory";
            this.TitleHistory.Size = new System.Drawing.Size(210, 46);
            this.TitleHistory.TabIndex = 2;
            this.TitleHistory.Text = "Historique";
            // 
            // compte
            // 
            this.compte.Controls.Add(this.label2);
            this.compte.Controls.Add(this.label1);
            this.compte.Controls.Add(this.removeUser);
            this.compte.Controls.Add(this.addUser);
            this.compte.Controls.Add(this.TitreAccount);
            this.compte.Controls.Add(this.tabAccount);
            this.compte.Location = new System.Drawing.Point(12, 27);
            this.compte.Name = "compte";
            this.compte.Size = new System.Drawing.Size(760, 522);
            this.compte.TabIndex = 4;
            this.compte.Paint += new System.Windows.Forms.PaintEventHandler(this.compte_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Supprimer un utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter un utilisateur";
            // 
            // removeUser
            // 
            this.removeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeUser.Image = global::projet_Fulbank.Properties.Resources.delete_user;
            this.removeUser.Location = new System.Drawing.Point(400, 58);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(53, 50);
            this.removeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeUser.TabIndex = 5;
            this.removeUser.TabStop = false;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // addUser
            // 
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Image = global::projet_Fulbank.Properties.Resources.add_user;
            this.addUser.Location = new System.Drawing.Point(283, 58);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(51, 50);
            this.addUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addUser.TabIndex = 4;
            this.addUser.TabStop = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.BackgroundColor = System.Drawing.Color.White;
            this.tabAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.Mail,
            this.Telephone,
            this.Adresse,
            this.CodePostale,
            this.Ville,
            this.Pays,
            this.Login,
            this.MotDePasse,
            this.Type});
            this.tabAccount.Location = new System.Drawing.Point(0, 131);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(760, 391);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabaccount_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 54;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 68;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.Width = 51;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 83;
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.Width = 70;
            // 
            // CodePostale
            // 
            this.CodePostale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodePostale.HeaderText = "Code Postale";
            this.CodePostale.Name = "CodePostale";
            this.CodePostale.Width = 95;
            // 
            // Ville
            // 
            this.Ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.Width = 51;
            // 
            // Pays
            // 
            this.Pays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Pays.HeaderText = "Pays";
            this.Pays.Name = "Pays";
            this.Pays.Width = 55;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 58;
            // 
            // MotDePasse
            // 
            this.MotDePasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MotDePasse.HeaderText = "MotDePasse";
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.ReadOnly = true;
            this.MotDePasse.Width = 93;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 56;
            // 
            // TitreAccount
            // 
            this.TitreAccount.AutoSize = true;
            this.TitreAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TitreAccount.Location = new System.Drawing.Point(258, 0);
            this.TitreAccount.Name = "TitreAccount";
            this.TitreAccount.Size = new System.Drawing.Size(229, 46);
            this.TitreAccount.TabIndex = 0;
            this.TitreAccount.Text = "Utilisateurs";
            // 
            // AdminMenuStrip
            // 
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.AdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminMenuStrip.Name = "AdminMenuStrip";
            this.AdminMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.AdminMenuStrip.TabIndex = 3;
            this.AdminMenuStrip.Text = "menuStrip1";
            this.AdminMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AdminMenuStrip_ItemClicked);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.historyToolStripMenuItem.Text = "Historique";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.accountToolStripMenuItem.Text = "Compte";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // tabAccountHistorical
            // 
            this.tabAccountHistorical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabAccountHistorical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientHistorical,
            this.lastNameClientHistorical,
            this.firstNameClientHistorical});
            this.tabAccountHistorical.Location = new System.Drawing.Point(3, 100);
            this.tabAccountHistorical.Name = "tabAccountHistorical";
            this.tabAccountHistorical.Size = new System.Drawing.Size(240, 150);
            this.tabAccountHistorical.TabIndex = 4;
            this.tabAccountHistorical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabAccountHistorical_CellContentClick);
            // 
            // idClientHistorical
            // 
            this.idClientHistorical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idClientHistorical.HeaderText = "ID";
            this.idClientHistorical.Name = "idClientHistorical";
            this.idClientHistorical.ReadOnly = true;
            this.idClientHistorical.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idClientHistorical.Width = 43;
            // 
            // lastNameClientHistorical
            // 
            this.lastNameClientHistorical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameClientHistorical.HeaderText = "Nom";
            this.lastNameClientHistorical.Name = "lastNameClientHistorical";
            this.lastNameClientHistorical.ReadOnly = true;
            // 
            // firstNameClientHistorical
            // 
            this.firstNameClientHistorical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameClientHistorical.HeaderText = "Prénom";
            this.firstNameClientHistorical.Name = "firstNameClientHistorical";
            this.firstNameClientHistorical.ReadOnly = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AdminMenuStrip);
            this.Controls.Add(this.compte);
            this.Controls.Add(this.historique);
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabhistory)).EndInit();
            this.historique.ResumeLayout(false);
            this.historique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).EndInit();
            this.compte.ResumeLayout(false);
            this.compte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).EndInit();
            this.AdminMenuStrip.ResumeLayout(false);
            this.AdminMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccountHistorical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabhistory;
        private System.Windows.Forms.Panel historique;
        private System.Windows.Forms.Label TitleHistory;
        private System.Windows.Forms.DataGridView tabclient;
        private System.Windows.Forms.MenuStrip AdminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Panel compte;
        private System.Windows.Forms.Label TitreAccount;
        private System.Windows.Forms.DataGridView tabAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotDePasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox removeUser;
        private System.Windows.Forms.PictureBox addUser;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.DataGridView tabAccountHistorical;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientHistorical;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameClientHistorical;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameClientHistorical;
    }
}