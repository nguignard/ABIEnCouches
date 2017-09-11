﻿using System;
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
    public partial class frmVisuContrat : Form
    {
        private ContratType leContrat;
        private frmVisuCollaborateur leForm;

        public frmVisuContrat(frmVisuCollaborateur unForm)
        {
            this.leForm = unForm;
            InitializeComponent();
            unForm.grdContrats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContrats_CellContentClick);

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("aa", "bb", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez vous réinitialiser les champs, Yes pour confirmer", "Réinitialisation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.AfficheContrat();
                this.AfficheWindowContrat();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //TODO
        }
        private void grdContrats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           
        }



        //FONCTIONS 

        internal void AfficheContrat()
        {
            this.rdbCDI.Checked = true;
            this.txtQualif.Text = leContrat.Qualification.ToString();
            this.txtSalaire.Text = leContrat.SalaireContractuel.ToString();
            this.txtStatut.Text = leContrat.Statut;

            if(leContrat is ContratTemporaire)
            {
                ContratTemporaire  leTemp = (ContratTemporaire)leContrat;

                this.txtMotif.Text = leTemp.Motif;
                this.dateFin.Value= leTemp.DatFinContrat.Date;
            }

            if (leContrat is Cdd)
            {
                Cdd leTemp = (Cdd)leContrat;
                this.rdbCDD.Checked = true;

            }

            if (leContrat is Stagiaire)
            {
                Stagiaire leTemp = (Stagiaire)leContrat;
                this.rdbStage.Checked = true;
                this.txtEcole.Text = leTemp.Ecole;
                this.txtMission.Text = leTemp.Mission;
            }
           

        }

        /// <summary>
        /// AfficheBoxContrat() gere les accessibilités des composants du form en fonction du type de contrat
        /// </summary>
        internal void AfficheWindowContrat()
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

            if (this.rdbCDD.Checked == true)
            {
                this.grpStage.Enabled = false;
            }
        }





    }
}
