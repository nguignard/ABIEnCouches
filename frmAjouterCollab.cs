using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    public partial class frmAjouterCollab : Form
    {
        public frmAjouterCollab()
        {
            InitializeComponent();
            this.whiteForm();
            this.AfficheContrat();
        }

        internal void Instancie()
        {
            try
            {
                private string sexe = "F";
                if (this.rdbM.Checked )
                {
                    newCollaborateur.Civilite = "M";
                }

                newCollaborateur.NomCollab = this.txtNom.Text;
                newCollaborateur.PrenomCollab = this.txtNom.Text;
                newCollaborateur.SituationFamiliale = this.cmbFamille.SelectedItem.ToString();





                
                    
                    
                //    .enabled = true;
                //this.lbldatefin.enabled = false;
                
                //this.lbldatedebut.enabled = true;
                //this.lblnom.enabled = true;
                //this.lblprenom.enabled = true;
                //this.lblqualification.enabled = true;
                //this.lblsalaire.enabled = true;
                //this.lblsituation.enabled = true;
                //this.lblstatut.enabled = true;
                //this.lblecole.enabled = true;
                //this.lblmission.enabled = true;





            }
            catch (Exception ex)
            {

                throw ;
            }
        }






        /// <summary>
        /// btnCancel_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous réinitialiser les champs, Yes pour confirmer", "Réinitialisation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.whiteForm();
                this.AfficheContrat();
            }
        }

        /// <summary>
        /// btnFermer_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous fermer la fenêtre, Yes pour confirmer", "Fermeture", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// whiteForm() réinitialise le form en blanc
        /// </summary>
        private void whiteForm()
        {
            this.txtNom.Text = "";
            this.txtPrenom.Text = "";
            this.txtEcole.Text = "";
            this.txtMission.Text = "";
            this.txtMotif.Text = "";
            this.txtQualif.Text = "";
            this.txtSalaire.Text = "";
            this.txtStatut.Text = "";
            this.cmbFamille.Items.AddRange(new String[] { "Celibataire","Marié","Divorcer"});


            this.rdbCDI.Checked = true;
            this.rdbM.Checked = true;

            //this.lblStatut.Text = "";
            //this.lblEcole.Text = "";
            //this.lblMission.Text = "";
            //this.lblMotif.Text = "";
            }

        // GESTION DE L'AFFICHGE DE CHAMPS DE CONTRAT----------------------------------------------------------
        /// <summary>
        /// AfficheContrat() gere les accessibilités des composants du form en fonction du type de contrat
        /// </summary>
        private void AfficheContrat()
        {
            //this.lblDateFin.Enabled = false;
            //this.lblCivilite.Enabled = true;
            //this.lblDateDebut.Enabled = true;
            //this.lblNom.Enabled = true;
            //this.lblPrenom.Enabled = true;
            //this.lblQualification.Enabled = true;
            //this.lblSalaire.Enabled = true;
            //this.lblSituation.Enabled = true;
            //this.lblStatut.Enabled = true;
            //this.lblEcole.Enabled = true;
            //this.lblMission.Enabled = true;


            this.Text = "Nouveau Collaborateur";
            this.dateFin.Enabled = true;
            this.txtMotif.Enabled = true;
            this.lblMotif.Enabled = true;
            this.grpStage.Enabled = true;

            if (this.rdbCDI.Checked == true)
            {
                this.dateFin.Enabled = false;
                this.txtMotif.Enabled = false;
                this.lblMotif.Enabled = false;
                this.grpStage.Enabled = false;
            }

            if(this.rdbCDD.Checked == true)
            {
                this.grpStage.Enabled = false;
            }
        }

        /// <summary>
        /// rdbCDI_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCDI_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheContrat();
        }

        /// <summary>
        /// rdbCDD_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCDD_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheContrat();
        }

        /// <summary>
        /// rdbStage_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbStage_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficheContrat();
        }
    }
}
