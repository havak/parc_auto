﻿namespace Parc_Auto.Forms
{
    partial class FrmAjouterPersonne
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_FAJouterPersonne_Nom = new System.Windows.Forms.TextBox();
            this.tb_FAJouterPersonne_Prenom = new System.Windows.Forms.TextBox();
            this.tb_FAJouterPersonne_Ville = new System.Windows.Forms.TextBox();
            this.bt_FAJouterPersonne_Fermer = new System.Windows.Forms.Button();
            this.bt_FAJouterPersonne_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une personne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville :";
            // 
            // tb_FAJouterPersonne_Nom
            // 
            this.tb_FAJouterPersonne_Nom.Location = new System.Drawing.Point(132, 104);
            this.tb_FAJouterPersonne_Nom.Name = "tb_FAJouterPersonne_Nom";
            this.tb_FAJouterPersonne_Nom.Size = new System.Drawing.Size(232, 20);
            this.tb_FAJouterPersonne_Nom.TabIndex = 4;
            // 
            // tb_FAJouterPersonne_Prenom
            // 
            this.tb_FAJouterPersonne_Prenom.Location = new System.Drawing.Point(132, 144);
            this.tb_FAJouterPersonne_Prenom.Name = "tb_FAJouterPersonne_Prenom";
            this.tb_FAJouterPersonne_Prenom.Size = new System.Drawing.Size(232, 20);
            this.tb_FAJouterPersonne_Prenom.TabIndex = 5;
            // 
            // tb_FAJouterPersonne_Ville
            // 
            this.tb_FAJouterPersonne_Ville.Location = new System.Drawing.Point(132, 193);
            this.tb_FAJouterPersonne_Ville.Name = "tb_FAJouterPersonne_Ville";
            this.tb_FAJouterPersonne_Ville.Size = new System.Drawing.Size(232, 20);
            this.tb_FAJouterPersonne_Ville.TabIndex = 6;
            // 
            // bt_FAJouterPersonne_Fermer
            // 
            this.bt_FAJouterPersonne_Fermer.Location = new System.Drawing.Point(55, 280);
            this.bt_FAJouterPersonne_Fermer.Name = "bt_FAJouterPersonne_Fermer";
            this.bt_FAJouterPersonne_Fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FAJouterPersonne_Fermer.TabIndex = 7;
            this.bt_FAJouterPersonne_Fermer.Text = "Fermer";
            this.bt_FAJouterPersonne_Fermer.UseVisualStyleBackColor = true;
            this.bt_FAJouterPersonne_Fermer.Click += new System.EventHandler(this.bt_FAJouterPersonne_Fermer_Click);
            // 
            // bt_FAJouterPersonne_Ajouter
            // 
            this.bt_FAJouterPersonne_Ajouter.Location = new System.Drawing.Point(248, 280);
            this.bt_FAJouterPersonne_Ajouter.Name = "bt_FAJouterPersonne_Ajouter";
            this.bt_FAJouterPersonne_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_FAJouterPersonne_Ajouter.TabIndex = 8;
            this.bt_FAJouterPersonne_Ajouter.Text = "Ajouter";
            this.bt_FAJouterPersonne_Ajouter.UseVisualStyleBackColor = true;
            this.bt_FAJouterPersonne_Ajouter.Click += new System.EventHandler(this.bt_FAJouterPersonne_Ajouter_Click);
            // 
            // FrmAjouterPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 340);
            this.Controls.Add(this.bt_FAJouterPersonne_Ajouter);
            this.Controls.Add(this.bt_FAJouterPersonne_Fermer);
            this.Controls.Add(this.tb_FAJouterPersonne_Ville);
            this.Controls.Add(this.tb_FAJouterPersonne_Prenom);
            this.Controls.Add(this.tb_FAJouterPersonne_Nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjouterPersonne";
            this.Text = "FrmAjouterPersonne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_FAJouterPersonne_Nom;
        private System.Windows.Forms.TextBox tb_FAJouterPersonne_Prenom;
        private System.Windows.Forms.TextBox tb_FAJouterPersonne_Ville;
        private System.Windows.Forms.Button bt_FAJouterPersonne_Fermer;
        private System.Windows.Forms.Button bt_FAJouterPersonne_Ajouter;
    }
}