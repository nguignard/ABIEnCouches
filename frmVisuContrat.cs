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
    public partial class frmVisuContrat : Form
    {
        private ContratType leContrat;
  

        public frmVisuContrat(ContratType leContrat)
        {
            this.leContrat = leContrat;
            InitializeComponent();
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
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //TODO
        }

        //FONCTIONS 

        private void AfficheContrat()
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
        

            this.txtEcole.Text = this.leContrat.;
            this.txtMission.Text = "";
        }




    }
}
