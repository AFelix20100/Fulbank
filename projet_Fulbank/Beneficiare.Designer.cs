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
            this.BeneficiaryAccountNumber = new System.Windows.Forms.Label();
            this.BeneficiaryLastName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iban_beneficiaire = new System.Windows.Forms.TextBox();
            this.transfertExternal = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewExternalBeneficiary = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_beneficiary = new System.Windows.Forms.Label();
            this.NameBeneficiary = new System.Windows.Forms.TextBox();
            this.ExternalTransfer = new System.Windows.Forms.Panel();
            this.account = new System.Windows.Forms.Label();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.CurrentAccount = new System.Windows.Forms.RadioButton();
            this.SavingAccount = new System.Windows.Forms.RadioButton();
            this.transfer_amount = new System.Windows.Forms.Label();
            this.TransferAmount = new System.Windows.Forms.TextBox();
            this.externalBeneficiairy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExternalBeneficiary)).BeginInit();
            this.ExternalTransfer.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
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
            // BeneficiaryAccountNumber
            // 
            this.BeneficiaryAccountNumber.AutoSize = true;
            this.BeneficiaryAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeneficiaryAccountNumber.Location = new System.Drawing.Point(12, 24);
            this.BeneficiaryAccountNumber.Name = "BeneficiaryAccountNumber";
            this.BeneficiaryAccountNumber.Size = new System.Drawing.Size(0, 15);
            this.BeneficiaryAccountNumber.TabIndex = 54;
            // 
            // BeneficiaryLastName
            // 
            this.BeneficiaryLastName.AutoSize = true;
            this.BeneficiaryLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeneficiaryLastName.Location = new System.Drawing.Point(12, 9);
            this.BeneficiaryLastName.Name = "BeneficiaryLastName";
            this.BeneficiaryLastName.Size = new System.Drawing.Size(0, 15);
            this.BeneficiaryLastName.TabIndex = 53;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(3, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Iban du bénéficiaire";
            // 
            // iban_beneficiaire
            // 
            this.iban_beneficiaire.Location = new System.Drawing.Point(3, 453);
            this.iban_beneficiaire.Name = "iban_beneficiaire";
            this.iban_beneficiaire.Size = new System.Drawing.Size(233, 20);
            this.iban_beneficiaire.TabIndex = 60;
            this.iban_beneficiaire.TextChanged += new System.EventHandler(this.iban_beneficiaire_TextChanged);
            // 
            // transfertExternal
            // 
            this.transfertExternal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.transfertExternal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfertExternal.FlatAppearance.BorderSize = 0;
            this.transfertExternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfertExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfertExternal.ForeColor = System.Drawing.Color.White;
            this.transfertExternal.Location = new System.Drawing.Point(587, 467);
            this.transfertExternal.Name = "transfertExternal";
            this.transfertExternal.Size = new System.Drawing.Size(110, 33);
            this.transfertExternal.TabIndex = 62;
            this.transfertExternal.Text = "Valider";
            this.transfertExternal.UseVisualStyleBackColor = false;
            this.transfertExternal.Click += new System.EventHandler(this.transfertExternal_Click);
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
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(12, 490);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 23);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 44);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridViewExternalBeneficiary
            // 
            this.dataGridViewExternalBeneficiary.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExternalBeneficiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExternalBeneficiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Iban});
            this.dataGridViewExternalBeneficiary.Location = new System.Drawing.Point(180, 212);
            this.dataGridViewExternalBeneficiary.Name = "dataGridViewExternalBeneficiary";
            this.dataGridViewExternalBeneficiary.Size = new System.Drawing.Size(425, 204);
            this.dataGridViewExternalBeneficiary.TabIndex = 65;
            this.dataGridViewExternalBeneficiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExternalBeneficiary_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Iban
            // 
            this.Iban.Frozen = true;
            this.Iban.HeaderText = "Iban";
            this.Iban.Name = "Iban";
            this.Iban.ReadOnly = true;
            // 
            // name_beneficiary
            // 
            this.name_beneficiary.AutoSize = true;
            this.name_beneficiary.BackColor = System.Drawing.Color.Transparent;
            this.name_beneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Bold);
            this.name_beneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.name_beneficiary.Location = new System.Drawing.Point(3, 364);
            this.name_beneficiary.Name = "name_beneficiary";
            this.name_beneficiary.Size = new System.Drawing.Size(177, 20);
            this.name_beneficiary.TabIndex = 66;
            this.name_beneficiary.Text = "Nom du bénéficiaire";
            // 
            // NameBeneficiary
            // 
            this.NameBeneficiary.Location = new System.Drawing.Point(3, 387);
            this.NameBeneficiary.Name = "NameBeneficiary";
            this.NameBeneficiary.Size = new System.Drawing.Size(171, 20);
            this.NameBeneficiary.TabIndex = 67;
            this.NameBeneficiary.TextChanged += new System.EventHandler(this.NameBeneficiary_TextChanged);
            // 
            // ExternalTransfer
            // 
            this.ExternalTransfer.Controls.Add(this.externalBeneficiairy);
            this.ExternalTransfer.Controls.Add(this.TransferAmount);
            this.ExternalTransfer.Controls.Add(this.transfer_amount);
            this.ExternalTransfer.Controls.Add(this.groupBoxAccount);
            this.ExternalTransfer.Controls.Add(this.account);
            this.ExternalTransfer.Location = new System.Drawing.Point(180, 194);
            this.ExternalTransfer.Name = "ExternalTransfer";
            this.ExternalTransfer.Size = new System.Drawing.Size(425, 222);
            this.ExternalTransfer.TabIndex = 68;
            this.ExternalTransfer.Paint += new System.Windows.Forms.PaintEventHandler(this.ExternalTransfer_Paint);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Cursor = System.Windows.Forms.Cursors.Default;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.account.Location = new System.Drawing.Point(15, 18);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(171, 18);
            this.account.TabIndex = 0;
            this.account.Text = "Depuis quel compte ?";
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.SavingAccount);
            this.groupBoxAccount.Controls.Add(this.CurrentAccount);
            this.groupBoxAccount.Location = new System.Drawing.Point(18, 40);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(168, 92);
            this.groupBoxAccount.TabIndex = 1;
            this.groupBoxAccount.TabStop = false;
            // 
            // CurrentAccount
            // 
            this.CurrentAccount.AutoSize = true;
            this.CurrentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CurrentAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.CurrentAccount.Location = new System.Drawing.Point(6, 19);
            this.CurrentAccount.Name = "CurrentAccount";
            this.CurrentAccount.Size = new System.Drawing.Size(142, 21);
            this.CurrentAccount.TabIndex = 0;
            this.CurrentAccount.TabStop = true;
            this.CurrentAccount.Text = "Compte Courant";
            this.CurrentAccount.UseVisualStyleBackColor = true;
            // 
            // SavingAccount
            // 
            this.SavingAccount.AutoSize = true;
            this.SavingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SavingAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.SavingAccount.Location = new System.Drawing.Point(7, 47);
            this.SavingAccount.Name = "SavingAccount";
            this.SavingAccount.Size = new System.Drawing.Size(87, 21);
            this.SavingAccount.TabIndex = 1;
            this.SavingAccount.TabStop = true;
            this.SavingAccount.Text = "Livret A ";
            this.SavingAccount.UseVisualStyleBackColor = true;
            // 
            // transfer_amount
            // 
            this.transfer_amount.AutoSize = true;
            this.transfer_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.transfer_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.transfer_amount.Location = new System.Drawing.Point(234, 15);
            this.transfer_amount.Name = "transfer_amount";
            this.transfer_amount.Size = new System.Drawing.Size(163, 36);
            this.transfer_amount.TabIndex = 2;
            this.transfer_amount.Text = "Somme du virement \r\npour";
            this.transfer_amount.Click += new System.EventHandler(this.transfer_amount_Click);
            // 
            // TransferAmount
            // 
            this.TransferAmount.Location = new System.Drawing.Point(237, 59);
            this.TransferAmount.Name = "TransferAmount";
            this.TransferAmount.Size = new System.Drawing.Size(160, 20);
            this.TransferAmount.TabIndex = 3;
            // 
            // externalBeneficiairy
            // 
            this.externalBeneficiairy.AutoSize = true;
            this.externalBeneficiairy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.externalBeneficiairy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.externalBeneficiairy.Location = new System.Drawing.Point(277, 33);
            this.externalBeneficiairy.Name = "externalBeneficiairy";
            this.externalBeneficiairy.Size = new System.Drawing.Size(0, 18);
            this.externalBeneficiairy.TabIndex = 4;
            this.externalBeneficiairy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Beneficiare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ExternalTransfer);
            this.Controls.Add(this.NameBeneficiary);
            this.Controls.Add(this.name_beneficiary);
            this.Controls.Add(this.dataGridViewExternalBeneficiary);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.transfertExternal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.iban_beneficiaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BeneficiaryAccountNumber);
            this.Controls.Add(this.BeneficiaryLastName);
            this.Controls.Add(this.logo);
            this.Name = "Beneficiare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiare";
            this.Load += new System.EventHandler(this.Beneficiare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExternalBeneficiary)).EndInit();
            this.ExternalTransfer.ResumeLayout(false);
            this.ExternalTransfer.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BeneficiaryAccountNumber;
        private System.Windows.Forms.Label BeneficiaryLastName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iban_beneficiaire;
        private System.Windows.Forms.Button transfertExternal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewExternalBeneficiary;
        private System.Windows.Forms.Label name_beneficiary;
        private System.Windows.Forms.TextBox NameBeneficiary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iban;
        private System.Windows.Forms.Panel ExternalTransfer;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.RadioButton CurrentAccount;
        private System.Windows.Forms.RadioButton SavingAccount;
        private System.Windows.Forms.TextBox TransferAmount;
        private System.Windows.Forms.Label transfer_amount;
        private System.Windows.Forms.Label externalBeneficiairy;
    }
}