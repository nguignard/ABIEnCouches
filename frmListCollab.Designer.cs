namespace ABIEnCouches
{
    partial class frmListCollab
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
            this.grdCollaborateurs = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnArchiver = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollaborateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCollaborateurs
            // 
            this.grdCollaborateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollaborateurs.Location = new System.Drawing.Point(12, 98);
            this.grdCollaborateurs.Name = "grdCollaborateurs";
            this.grdCollaborateurs.Size = new System.Drawing.Size(806, 311);
            this.grdCollaborateurs.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(662, 487);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
          
            // 
            // btnArchiver
            // 
            this.btnArchiver.Location = new System.Drawing.Point(743, 487);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(75, 23);
            this.btnArchiver.TabIndex = 5;
            this.btnArchiver.Text = "Archiver";
            this.btnArchiver.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(743, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(725, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // frmListCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 519);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnArchiver);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdCollaborateurs);
            this.Name = "frmListCollab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des Collaborateurs";
            ((System.ComponentModel.ISupportInitialize)(this.grdCollaborateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCollaborateurs;
        internal System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnArchiver;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}