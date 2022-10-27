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
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
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
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreAccount = new System.Windows.Forms.Label();
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabhistory)).BeginInit();
            this.historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).BeginInit();
            this.compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).BeginInit();
            this.AdminMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabhistory
            // 
            this.tabhistory.BackgroundColor = System.Drawing.Color.White;
            this.tabhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabhistory.Location = new System.Drawing.Point(111, 315);
            this.tabhistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabhistory.Name = "tabhistory";
            this.tabhistory.Size = new System.Drawing.Size(801, 324);
            this.tabhistory.TabIndex = 1;
            // 
            // historique
            // 
            this.historique.Controls.Add(this.tabclient);
            this.historique.Controls.Add(this.TitleHistory);
            this.historique.Controls.Add(this.tabhistory);
            this.historique.Location = new System.Drawing.Point(17, 33);
            this.historique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(1012, 642);
            this.historique.TabIndex = 2;
            this.historique.Paint += new System.Windows.Forms.PaintEventHandler(this.historique_Paint);
            // 
            // tabclient
            // 
            this.tabclient.BackgroundColor = System.Drawing.Color.White;
            this.tabclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabclient.GridColor = System.Drawing.Color.Black;
            this.tabclient.Location = new System.Drawing.Point(4, 123);
            this.tabclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabclient.Name = "tabclient";
            this.tabclient.Size = new System.Drawing.Size(320, 185);
            this.tabclient.TabIndex = 3;
            // 
            // TitleHistory
            // 
            this.TitleHistory.AutoSize = true;
            this.TitleHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TitleHistory.Location = new System.Drawing.Point(385, 11);
            this.TitleHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleHistory.Name = "TitleHistory";
            this.TitleHistory.Size = new System.Drawing.Size(210, 46);
            this.TitleHistory.TabIndex = 2;
            this.TitleHistory.Text = "Historique";
            // 
            // compte
            // 
            this.compte.Controls.Add(this.delete);
            this.compte.Controls.Add(this.create);
            this.compte.Controls.Add(this.tabAccount);
            this.compte.Controls.Add(this.TitreAccount);
            this.compte.Location = new System.Drawing.Point(16, 33);
            this.compte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compte.Name = "compte";
            this.compte.Size = new System.Drawing.Size(1013, 642);
            this.compte.TabIndex = 4;
            this.compte.Paint += new System.Windows.Forms.PaintEventHandler(this.compte_Paint);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(967, 155);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(32, 53);
            this.delete.TabIndex = 3;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // create
            // 
            this.create.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(921, 161);
            this.create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(37, 42);
            this.create.TabIndex = 2;
            this.create.Text = "+";
            this.create.UseVisualStyleBackColor = true;
            this.create.UseWaitCursor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
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
            this.Type});
            this.tabAccount.Location = new System.Drawing.Point(29, 161);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(884, 454);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabaccount_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 45;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 61;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 79;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.Width = 57;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 98;
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.Width = 83;
            // 
            // CodePostale
            // 
            this.CodePostale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodePostale.HeaderText = "Code Postale";
            this.CodePostale.Name = "CodePostale";
            this.CodePostale.Width = 114;
            // 
            // Ville
            // 
            this.Ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.Width = 58;
            // 
            // Pays
            // 
            this.Pays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Pays.HeaderText = "Pays";
            this.Pays.Name = "Pays";
            this.Pays.Width = 63;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 64;
            // 
            // TitreAccount
            // 
            this.TitreAccount.AutoSize = true;
            this.TitreAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.TitreAccount.Location = new System.Drawing.Point(387, 0);
            this.TitreAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitreAccount.Name = "TitreAccount";
            this.TitreAccount.Size = new System.Drawing.Size(166, 46);
            this.TitreAccount.TabIndex = 0;
            this.TitreAccount.Text = "Compte";
            // 
            // AdminMenuStrip
            // 
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.AdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminMenuStrip.Name = "AdminMenuStrip";
            this.AdminMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.AdminMenuStrip.Size = new System.Drawing.Size(1045, 24);
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
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.compte);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.AdminMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).EndInit();
            this.AdminMenuStrip.ResumeLayout(false);
            this.AdminMenuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Panel compte;
        private System.Windows.Forms.Label TitreAccount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button create;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}