namespace ABIEnCouches
{
    partial class frmAjouterCollab
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
            this.grpCivil = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.lblCivilite = new System.Windows.Forms.Label();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.txtNumeroMatricule = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnAjouterPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCivil
            // 
            this.grpCivil.Controls.Add(this.rdbF);
            this.grpCivil.Controls.Add(this.rdbM);
            this.grpCivil.Location = new System.Drawing.Point(142, 181);
            this.grpCivil.Name = "grpCivil";
            this.grpCivil.Size = new System.Drawing.Size(200, 36);
            this.grpCivil.TabIndex = 39;
            this.grpCivil.TabStop = false;
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
            // lblCivilite
            // 
            this.lblCivilite.AutoSize = true;
            this.lblCivilite.Location = new System.Drawing.Point(19, 196);
            this.lblCivilite.Name = "lblCivilite";
            this.lblCivilite.Size = new System.Drawing.Size(37, 13);
            this.lblCivilite.TabIndex = 38;
            this.lblCivilite.Text = "Civilité";
            // 
            // cmbFamille
            // 
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Items.AddRange(new object[] {
            "Celibataire",
            "Marie",
            "Divorce"});
            this.cmbFamille.Location = new System.Drawing.Point(142, 271);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(200, 21);
            this.cmbFamille.TabIndex = 37;
            // 
            // txtNumeroMatricule
            // 
            this.txtNumeroMatricule.Location = new System.Drawing.Point(142, 161);
            this.txtNumeroMatricule.Name = "txtNumeroMatricule";
            this.txtNumeroMatricule.ReadOnly = true;
            this.txtNumeroMatricule.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroMatricule.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 33;
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctBox.Location = new System.Drawing.Point(21, 12);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(135, 130);
            this.pctBox.TabIndex = 32;
            this.pctBox.TabStop = false;
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(19, 274);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(91, 13);
            this.lblSituation.TabIndex = 31;
            this.lblSituation.Text = "Situation Familiale";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(19, 251);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 30;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(19, 226);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 29;
            this.lblNom.Text = "Nom";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(19, 302);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(93, 13);
            this.lblDateEmbauche.TabIndex = 28;
            this.lblDateEmbauche.Text = "Date D\'embauche";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(19, 164);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 27;
            this.lblMatricule.Text = "Matricule";
            // 
            // btnAjouterPhoto
            // 
            this.btnAjouterPhoto.Location = new System.Drawing.Point(206, 69);
            this.btnAjouterPhoto.Name = "btnAjouterPhoto";
            this.btnAjouterPhoto.Size = new System.Drawing.Size(106, 23);
            this.btnAjouterPhoto.TabIndex = 40;
            this.btnAjouterPhoto.Text = "Ajouter une Photo";
            this.btnAjouterPhoto.UseVisualStyleBackColor = true;
            this.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(105, 344);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 41;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(267, 344);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 43;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmAjouterCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 379);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouterPhoto);
            this.Controls.Add(this.grpCivil);
            this.Controls.Add(this.lblCivilite);
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
            this.Name = "frmAjouterCollab";
            this.Text = "frmAjouterCollab";
            this.grpCivil.ResumeLayout(false);
            this.grpCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCivil;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label lblCivilite;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.TextBox txtNumeroMatricule;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Button btnAjouterPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFermer;
    }
}