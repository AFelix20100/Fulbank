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
            this.tabhistorique = new System.Windows.Forms.DataGridView();
            this.historique = new System.Windows.Forms.Panel();
            this.compte = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.tabcompte = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabclient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabhistorique)).BeginInit();
            this.historique.SuspendLayout();
            this.compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabhistorique
            // 
            this.tabhistorique.BackgroundColor = System.Drawing.Color.White;
            this.tabhistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabhistorique.Location = new System.Drawing.Point(83, 256);
            this.tabhistorique.Name = "tabhistorique";
            this.tabhistorique.Size = new System.Drawing.Size(601, 263);
            this.tabhistorique.TabIndex = 1;
            // 
            // historique
            // 
            this.historique.Controls.Add(this.compte);
            this.historique.Controls.Add(this.tabclient);
            this.historique.Controls.Add(this.label1);
            this.historique.Controls.Add(this.tabhistorique);
            this.historique.Location = new System.Drawing.Point(13, 27);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(759, 522);
            this.historique.TabIndex = 2;
            this.historique.Paint += new System.Windows.Forms.PaintEventHandler(this.historique_Paint);
            // 
            // compte
            // 
            this.compte.Controls.Add(this.Delete);
            this.compte.Controls.Add(this.create);
            this.compte.Controls.Add(this.tabcompte);
            this.compte.Controls.Add(this.label2);
            this.compte.Location = new System.Drawing.Point(-1, 0);
            this.compte.Name = "compte";
            this.compte.Size = new System.Drawing.Size(760, 522);
            this.compte.TabIndex = 4;
            this.compte.Paint += new System.Windows.Forms.PaintEventHandler(this.compte_Paint);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(725, 126);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(24, 43);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "-";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(691, 131);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(28, 34);
            this.create.TabIndex = 2;
            this.create.Text = "+";
            this.create.UseVisualStyleBackColor = true;
            this.create.UseWaitCursor = true;
            // 
            // tabcompte
            // 
            this.tabcompte.BackgroundColor = System.Drawing.Color.White;
            this.tabcompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabcompte.Location = new System.Drawing.Point(22, 131);
            this.tabcompte.Name = "tabcompte";
            this.tabcompte.Size = new System.Drawing.Size(663, 369);
            this.tabcompte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(290, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Compte";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historique";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiqueToolStripMenuItem,
            this.compteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.historiqueToolStripMenuItem.Text = "Historique";
            this.historiqueToolStripMenuItem.Click += new System.EventHandler(this.historiqueToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.compteToolStripMenuItem_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.tabhistorique)).EndInit();
            this.historique.ResumeLayout(false);
            this.historique.PerformLayout();
            this.compte.ResumeLayout(false);
            this.compte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabhistorique;
        private System.Windows.Forms.Panel historique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabclient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.Panel compte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DataGridView tabcompte;
    }
}