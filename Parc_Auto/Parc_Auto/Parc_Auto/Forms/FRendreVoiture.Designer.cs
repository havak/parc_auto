﻿namespace Parc_Auto.Forms
{
    partial class FRendreVoiture
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
            this.cb_FRendreVoiture_voitureARendre = new System.Windows.Forms.ComboBox();
            this.bt_FRendreVoiture_fermer = new System.Windows.Forms.Button();
            this.bt_FRendreVoiture_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendre une voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voiture à rendre :";
            // 
            // cb_FRendreVoiture_voitureARendre
            // 
            this.cb_FRendreVoiture_voitureARendre.FormattingEnabled = true;
            this.cb_FRendreVoiture_voitureARendre.Location = new System.Drawing.Point(106, 114);
            this.cb_FRendreVoiture_voitureARendre.Name = "cb_FRendreVoiture_voitureARendre";
            this.cb_FRendreVoiture_voitureARendre.Size = new System.Drawing.Size(121, 21);
            this.cb_FRendreVoiture_voitureARendre.TabIndex = 2;
            // 
            // bt_FRendreVoiture_fermer
            // 
            this.bt_FRendreVoiture_fermer.Location = new System.Drawing.Point(106, 190);
            this.bt_FRendreVoiture_fermer.Name = "bt_FRendreVoiture_fermer";
            this.bt_FRendreVoiture_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_FRendreVoiture_fermer.TabIndex = 3;
            this.bt_FRendreVoiture_fermer.Text = "Fermer";
            this.bt_FRendreVoiture_fermer.UseVisualStyleBackColor = true;
            // 
            // bt_FRendreVoiture_valider
            // 
            this.bt_FRendreVoiture_valider.Location = new System.Drawing.Point(382, 190);
            this.bt_FRendreVoiture_valider.Name = "bt_FRendreVoiture_valider";
            this.bt_FRendreVoiture_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_FRendreVoiture_valider.TabIndex = 4;
            this.bt_FRendreVoiture_valider.Text = "Valider";
            this.bt_FRendreVoiture_valider.UseVisualStyleBackColor = true;
            // 
            // FRendreVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 269);
            this.Controls.Add(this.bt_FRendreVoiture_valider);
            this.Controls.Add(this.bt_FRendreVoiture_fermer);
            this.Controls.Add(this.cb_FRendreVoiture_voitureARendre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRendreVoiture";
            this.Text = "Rendre une Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FRendreVoiture_voitureARendre;
        private System.Windows.Forms.Button bt_FRendreVoiture_fermer;
        private System.Windows.Forms.Button bt_FRendreVoiture_valider;
    }
}