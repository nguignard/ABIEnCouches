﻿namespace ABIEnCouches
{
    partial class frmVisuCollaborateur
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
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroMatricule = new System.Windows.Forms.TextBox();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnArchiver = new System.Windows.Forms.Button();
            this.grdContrats = new System.Windows.Forms.DataGridView();
            this.lblContrats = new System.Windows.Forms.Label();
            this.btnCreateContrat = new System.Windows.Forms.Button();
            this.lblCivilite = new System.Windows.Forms.Label();
            this.grpCivil = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).BeginInit();
            this.grpCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(10, 164);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(10, 302);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(93, 13);
            this.lblDateEmbauche.TabIndex = 1;
            this.lblDateEmbauche.Text = "Date D\'embauche";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(10, 226);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(10, 251);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(10, 274);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(91, 13);
            this.lblSituation.TabIndex = 4;
            this.lblSituation.Text = "Situation Familiale";
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctBox.Location = new System.Drawing.Point(12, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(135, 130);
            this.pctBox.TabIndex = 6;
            this.pctBox.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // txtNumeroMatricule
            // 
            this.txtNumeroMatricule.Location = new System.Drawing.Point(133, 161);
            this.txtNumeroMatricule.Name = "txtNumeroMatricule";
            this.txtNumeroMatricule.ReadOnly = true;
            this.txtNumeroMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroMatricule.TabIndex = 18;
            this.txtNumeroMatricule.Text = "000";
            // 
            // cmbFamille
            // 
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Items.AddRange(new object[] {
            "Celibataire",
            "Marie",
            "Divorce"});
            this.cmbFamille.Location = new System.Drawing.Point(133, 271);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(200, 21);
            this.cmbFamille.TabIndex = 19;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(45, 332);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 22);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "&Modifier Collaborateur";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnArchiver
            // 
            this.btnArchiver.Location = new System.Drawing.Point(181, 332);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(132, 22);
            this.btnArchiver.TabIndex = 21;
            this.btnArchiver.Text = "&Archiver Collaborateur";
            this.btnArchiver.UseVisualStyleBackColor = true;
            // 
            // grdContrats
            // 
            this.grdContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContrats.Location = new System.Drawing.Point(401, 37);
            this.grdContrats.Name = "grdContrats";
            this.grdContrats.Size = new System.Drawing.Size(459, 281);
            this.grdContrats.TabIndex = 22;
            // 
            // lblContrats
            // 
            this.lblContrats.AutoSize = true;
            this.lblContrats.Location = new System.Drawing.Point(398, 12);
            this.lblContrats.Name = "lblContrats";
            this.lblContrats.Size = new System.Drawing.Size(46, 13);
            this.lblContrats.TabIndex = 23;
            this.lblContrats.Text = "Contrats";
            // 
            // btnCreateContrat
            // 
            this.btnCreateContrat.Location = new System.Drawing.Point(401, 332);
            this.btnCreateContrat.Name = "btnCreateContrat";
            this.btnCreateContrat.Size = new System.Drawing.Size(130, 22);
            this.btnCreateContrat.TabIndex = 24;
            this.btnCreateContrat.Text = "&Creer un Contrat";
            this.btnCreateContrat.UseVisualStyleBackColor = true;
            // 
            // lblCivilite
            // 
            this.lblCivilite.AutoSize = true;
            this.lblCivilite.Location = new System.Drawing.Point(10, 196);
            this.lblCivilite.Name = "lblCivilite";
            this.lblCivilite.Size = new System.Drawing.Size(37, 13);
            this.lblCivilite.TabIndex = 25;
            this.lblCivilite.Text = "Civilité";
            // 
            // grpCivil
            // 
            this.grpCivil.Controls.Add(this.rdbF);
            this.grpCivil.Controls.Add(this.rdbM);
            this.grpCivil.Location = new System.Drawing.Point(133, 181);
            this.grpCivil.Name = "grpCivil";
            this.grpCivil.Size = new System.Drawing.Size(200, 36);
            this.grpCivil.TabIndex = 26;
            this.grpCivil.TabStop = false;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(6, 13);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(109, 13);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 1;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // frmVisuCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 366);
            this.Controls.Add(this.grpCivil);
            this.Controls.Add(this.lblCivilite);
            this.Controls.Add(this.btnCreateContrat);
            this.Controls.Add(this.lblContrats);
            this.Controls.Add(this.grdContrats);
            this.Controls.Add(this.btnArchiver);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.txtNumeroMatricule);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.lblMatricule);
            this.Name = "frmVisuCollaborateur";
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmVisuCollaborateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).EndInit();
            this.grpCivil.ResumeLayout(false);
            this.grpCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumeroMatricule;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnArchiver;
        private System.Windows.Forms.DataGridView grdContrats;
        private System.Windows.Forms.Label lblContrats;
        private System.Windows.Forms.Button btnCreateContrat;
        private System.Windows.Forms.Label lblCivilite;
        private System.Windows.Forms.GroupBox grpCivil;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
    }
}