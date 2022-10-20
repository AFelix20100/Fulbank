
namespace projet_Fulbank
{
    partial class Virement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Virement));
            this.quelcompte = new System.Windows.Forms.Label();
            this.toaccount = new System.Windows.Forms.Label();
            this.VirementLastName = new System.Windows.Forms.Label();
            this.VirementAccountNumber = new System.Windows.Forms.Label();
            this.return_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.deb_current = new System.Windows.Forms.RadioButton();
            this.Sum = new System.Windows.Forms.Label();
            this.TransfertSum = new System.Windows.Forms.TextBox();
            this.transfert = new System.Windows.Forms.Button();
            this.deb_savings = new System.Windows.Forms.RadioButton();
            this.cred_current = new System.Windows.Forms.RadioButton();
            this.cred_savings = new System.Windows.Forms.RadioButton();
            this.beneficiary = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cred_account = new System.Windows.Forms.GroupBox();
            this.deb_account = new System.Windows.Forms.GroupBox();
            this.test = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.cred_account.SuspendLayout();
            this.deb_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // quelcompte
            // 
            this.quelcompte.AutoSize = true;
            this.quelcompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quelcompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.quelcompte.Location = new System.Drawing.Point(82, 215);
            this.quelcompte.Name = "quelcompte";
            this.quelcompte.Size = new System.Drawing.Size(183, 20);
            this.quelcompte.TabIndex = 52;
            this.quelcompte.Text = "Depuis quel compte ?";
            // 
            // toaccount
            // 
            this.toaccount.AutoSize = true;
            this.toaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.toaccount.Location = new System.Drawing.Point(516, 215);
            this.toaccount.Name = "toaccount";
            this.toaccount.Size = new System.Drawing.Size(169, 20);
            this.toaccount.TabIndex = 53;
            this.toaccount.Text = "Vers quel compte ? ";
            // 
            // VirementLastName
            // 
            this.VirementLastName.AutoSize = true;
            this.VirementLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementLastName.Location = new System.Drawing.Point(12, 9);
            this.VirementLastName.Name = "VirementLastName";
            this.VirementLastName.Size = new System.Drawing.Size(0, 15);
            this.VirementLastName.TabIndex = 47;
            this.VirementLastName.Click += new System.EventHandler(this.label13_Click);
            // 
            // VirementAccountNumber
            // 
            this.VirementAccountNumber.AutoSize = true;
            this.VirementAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirementAccountNumber.Location = new System.Drawing.Point(12, 24);
            this.VirementAccountNumber.Name = "VirementAccountNumber";
            this.VirementAccountNumber.Size = new System.Drawing.Size(0, 15);
            this.VirementAccountNumber.TabIndex = 48;
            this.VirementAccountNumber.Click += new System.EventHandler(this.label14_Click);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.return_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_button.FlatAppearance.BorderSize = 0;
            this.return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.ForeColor = System.Drawing.Color.White;
            this.return_button.Location = new System.Drawing.Point(12, 102);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(98, 23);
            this.return_button.TabIndex = 50;
            this.return_button.Text = "Retour";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.title.Location = new System.Drawing.Point(296, 139);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(202, 52);
            this.title.TabIndex = 51;
            this.title.Text = "Virement";
            this.title.Click += new System.EventHandler(this.titre_Click);
            // 
            // deb_current
            // 
            this.deb_current.AutoSize = true;
            this.deb_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.deb_current.Location = new System.Drawing.Point(6, 14);
            this.deb_current.Name = "deb_current";
            this.deb_current.Size = new System.Drawing.Size(140, 21);
            this.deb_current.TabIndex = 54;
            this.deb_current.Text = "Compte courant";
            this.deb_current.UseVisualStyleBackColor = true;
            this.deb_current.CheckedChanged += new System.EventHandler(this.deb_current_CheckedChanged);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Sum.Location = new System.Drawing.Point(83, 375);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(158, 18);
            this.Sum.TabIndex = 55;
            this.Sum.Text = "Somme du virement";
            // 
            // TransfertSum
            // 
            this.TransfertSum.BackColor = System.Drawing.SystemColors.Window;
            this.TransfertSum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TransfertSum.Location = new System.Drawing.Point(86, 396);
            this.TransfertSum.Name = "TransfertSum";
            this.TransfertSum.Size = new System.Drawing.Size(155, 20);
            this.TransfertSum.TabIndex = 56;
            this.TransfertSum.TextChanged += new System.EventHandler(this.TransfertSum_TextChanged);
            // 
            // transfert
            // 
            this.transfert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.transfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfert.FlatAppearance.BorderSize = 0;
            this.transfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfert.ForeColor = System.Drawing.Color.White;
            this.transfert.Location = new System.Drawing.Point(548, 383);
            this.transfert.Name = "transfert";
            this.transfert.Size = new System.Drawing.Size(110, 33);
            this.transfert.TabIndex = 58;
            this.transfert.Text = "Virer";
            this.transfert.UseVisualStyleBackColor = false;
            this.transfert.Click += new System.EventHandler(this.transfert_Click);
            // 
            // deb_savings
            // 
            this.deb_savings.AutoSize = true;
            this.deb_savings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_savings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.deb_savings.Location = new System.Drawing.Point(6, 41);
            this.deb_savings.Name = "deb_savings";
            this.deb_savings.Size = new System.Drawing.Size(82, 21);
            this.deb_savings.TabIndex = 59;
            this.deb_savings.TabStop = true;
            this.deb_savings.Text = "Livret A";
            this.deb_savings.UseVisualStyleBackColor = true;
            this.deb_savings.CheckedChanged += new System.EventHandler(this.deb_booklet_CheckedChanged);
            // 
            // cred_current
            // 
            this.cred_current.AutoSize = true;
            this.cred_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cred_current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.cred_current.Location = new System.Drawing.Point(6, 19);
            this.cred_current.Name = "cred_current";
            this.cred_current.Size = new System.Drawing.Size(140, 21);
            this.cred_current.TabIndex = 60;
            this.cred_current.TabStop = true;
            this.cred_current.Text = "Compte courant";
            this.cred_current.UseVisualStyleBackColor = true;
            this.cred_current.CheckedChanged += new System.EventHandler(this.cred_current_CheckedChanged);
            // 
            // cred_savings
            // 
            this.cred_savings.AutoSize = true;
            this.cred_savings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cred_savings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.cred_savings.Location = new System.Drawing.Point(6, 46);
            this.cred_savings.Name = "cred_savings";
            this.cred_savings.Size = new System.Drawing.Size(82, 21);
            this.cred_savings.TabIndex = 61;
            this.cred_savings.TabStop = true;
            this.cred_savings.Text = "Livret A";
            this.cred_savings.UseVisualStyleBackColor = true;
            // 
            // beneficiary
            // 
            this.beneficiary.BackColor = System.Drawing.SystemColors.Control;
            this.beneficiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beneficiary.FlatAppearance.BorderSize = 0;
            this.beneficiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.beneficiary.Location = new System.Drawing.Point(520, 340);
            this.beneficiary.Name = "beneficiary";
            this.beneficiary.Size = new System.Drawing.Size(154, 23);
            this.beneficiary.TabIndex = 62;
            this.beneficiary.Text = "Autre bénéficiares";
            this.beneficiary.UseVisualStyleBackColor = false;
            this.beneficiary.Click += new System.EventHandler(this.beneficiary_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(518, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 60);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 46;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // cred_account
            // 
            this.cred_account.Controls.Add(this.cred_current);
            this.cred_account.Controls.Add(this.cred_savings);
            this.cred_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cred_account.ForeColor = System.Drawing.Color.White;
            this.cred_account.Location = new System.Drawing.Point(520, 238);
            this.cred_account.Name = "cred_account";
            this.cred_account.Size = new System.Drawing.Size(154, 87);
            this.cred_account.TabIndex = 63;
            this.cred_account.TabStop = false;
            this.cred_account.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deb_account
            // 
            this.deb_account.Controls.Add(this.deb_current);
            this.deb_account.Controls.Add(this.deb_savings);
            this.deb_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deb_account.Location = new System.Drawing.Point(86, 238);
            this.deb_account.Name = "deb_account";
            this.deb_account.Size = new System.Drawing.Size(148, 81);
            this.deb_account.TabIndex = 64;
            this.deb_account.TabStop = false;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(304, 390);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 20);
            this.test.TabIndex = 65;
            this.test.TextChanged += new System.EventHandler(this.test_TextChanged);
            // 
            // Virement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.test);
            this.Controls.Add(this.deb_account);
            this.Controls.Add(this.cred_account);
            this.Controls.Add(this.beneficiary);
            this.Controls.Add(this.transfert);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TransfertSum);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.toaccount);
            this.Controls.Add(this.quelcompte);
            this.Controls.Add(this.title);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VirementAccountNumber);
            this.Controls.Add(this.VirementLastName);
            this.Controls.Add(this.logo);
            this.Name = "Virement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virement";
            this.Load += new System.EventHandler(this.Virement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.cred_account.ResumeLayout(false);
            this.cred_account.PerformLayout();
            this.deb_account.ResumeLayout(false);
            this.deb_account.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label quelcompte;
        private System.Windows.Forms.Label toaccount;
        private System.Windows.Forms.Label VirementLastName;
        private System.Windows.Forms.Label VirementAccountNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton deb_current;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.TextBox TransfertSum;
        private System.Windows.Forms.Button transfert;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton deb_savings;
        private System.Windows.Forms.RadioButton cred_current;
        private System.Windows.Forms.RadioButton cred_savings;
        private System.Windows.Forms.Button beneficiary;
        private System.Windows.Forms.GroupBox cred_account;
        private System.Windows.Forms.GroupBox deb_account;
        private System.Windows.Forms.TextBox test;
    }
}