using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_Fulbank
{
    public partial class CompteReleve : Form
    {
        private Label titre;
        private Button retour;
        private PictureBox pictureBox1;
        private Label label14;
        private Label label13;
        private PictureBox logo;

        public CompteReleve()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompteReleve));
            this.titre = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.titre.Location = new System.Drawing.Point(210, 139);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(379, 52);
            this.titre.TabIndex = 37;
            this.titre.Text = "Relevé de comptes";
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
            this.retour.TabIndex = 36;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 44);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "N° de compte :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Nom :";
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::projet_Fulbank.Properties.Resources.Logo_avec_bitcoin;
            this.logo.Location = new System.Drawing.Point(137, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(521, 143);
            this.logo.TabIndex = 32;
            this.logo.TabStop = false;
            // 
            // CompteReleve
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.logo);
            this.Name = "CompteReleve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
