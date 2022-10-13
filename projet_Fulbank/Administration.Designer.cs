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
            this.compte = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.tabaccount = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabclient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabhistory)).BeginInit();
            this.historique.SuspendLayout();
            this.compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabaccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.historique.Controls.Add(this.tabclient);
            this.historique.Controls.Add(this.label1);
            this.historique.Controls.Add(this.tabhistory);
            this.historique.Location = new System.Drawing.Point(13, 27);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(759, 522);
            this.historique.TabIndex = 2;
            this.historique.Paint += new System.Windows.Forms.PaintEventHandler(this.historique_Paint);
            // 
            // compte
            // 
            this.compte.Controls.Add(this.delete);
            this.compte.Controls.Add(this.create);
            this.compte.Controls.Add(this.tabaccount);
            this.compte.Controls.Add(this.label2);
            this.compte.Location = new System.Drawing.Point(12, 27);
            this.compte.Name = "compte";
            this.compte.Size = new System.Drawing.Size(760, 522);
            this.compte.TabIndex = 4;
            this.compte.Paint += new System.Windows.Forms.PaintEventHandler(this.compte_Paint);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(725, 126);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(24, 43);
            this.delete.TabIndex = 3;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = true;
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
            // tabaccount
            // 
            this.tabaccount.BackgroundColor = System.Drawing.Color.White;
            this.tabaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabaccount.Location = new System.Drawing.Point(22, 131);
            this.tabaccount.Name = "tabaccount";
            this.tabaccount.Size = new System.Drawing.Size(663, 369);
            this.tabaccount.TabIndex = 1;
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
            this.historyToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.compte);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.tabhistory)).EndInit();
            this.historique.ResumeLayout(false);
            this.historique.PerformLayout();
            this.compte.ResumeLayout(false);
            this.compte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabaccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabclient)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabhistory;
        private System.Windows.Forms.Panel historique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabclient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Panel compte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DataGridView tabaccount;
    }
}