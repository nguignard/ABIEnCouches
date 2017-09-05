using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIEnCouches
{
    public class ctrlListerCollaborateur
    {
        private Collaborateurs listeCollaborateurs;
        private frmListCollab frmCollaborateurs;
        private Collaborateur leCollaborateur;

        public ctrlListerCollaborateur()
        {
            this.instancieCollaborateurs();
            this.frmCollaborateurs.grdCollaborateurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCollaborateurs_DoubleClick);



            //this.frmCollaborateurs.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);


            ShowFormListeCollab(this.frmCollaborateurs);

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {


        }

        private void grdCollaborateurs_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 laCle; //matriculle
            laCle = (Int32)frmCollaborateurs.grdCollaborateurs.CurrentRow.Cells[0].Value;
            Collaborateur leCollaborateur = listeCollaborateurs.RestituerCollaborateur(laCle);
            ctrlVisuCollaborateur ctrlVisu = new ctrlVisuCollaborateur(leCollaborateur);

            this.frmCollaborateurs.afficheCollaborateurs(listeCollaborateurs);

        }






        /// <summary>
        /// initialiseListeCollab()
        /// </summary>
        private void instancieCollaborateurs()
        {

            listeCollaborateurs = new Collaborateurs();
            Collaborateur collaborateur = new Collaborateur("M", "DUPOND", "Roger", "marie", true);
            Cdi contrat = new Cdi(new DateTime(2010, 5, 5), "Chef de Projet", "Cadre", 5000);

            collaborateur.AddContrat(contrat);
            listeCollaborateurs.AddCollaborateur(collaborateur);
            collaborateur = new Collaborateur("Mme", "DUPONt", "Rogee", "marie", false);
            contrat = new Cdi(new DateTime(2012, 6, 6), "CDI", "employee", 1500);

            collaborateur.AddContrat(contrat);
            listeCollaborateurs.AddCollaborateur(collaborateur);
            Console.WriteLine(contrat.ToString());

            Console.Write(listeCollaborateurs.RestituerCollaborateur(2).ToString());
            Console.Write(collaborateur.RestituerContrat(2).ToString());
        }

        /// <summary>
        /// initialisation dialogue modal sur la liste des collaborateurs
        /// </summary>
        private void ShowFormListeCollab(frmListCollab frmCollaborateurs)
        {
            if (frmCollaborateurs == null)
            {
                frmCollaborateurs = new frmListCollab(this.listeCollaborateurs);
                frmCollaborateurs.MdiParent = frmMDI.Ref;
                frmCollaborateurs.FormClosing += new FormClosingEventHandler(this.closingFrmListCollab);
                frmCollaborateurs.Text = "Liste des Collaborateurs";
                frmCollaborateurs.Show();
            }
            else
            {
                frmCollaborateurs.Activate();
            }
        }

        private void closingFrmListCollab(object sender, FormClosingEventArgs e)
        {
            frmCollaborateurs = null;
        }




    }
}
