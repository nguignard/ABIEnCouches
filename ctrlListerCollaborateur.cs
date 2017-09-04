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


        private frmListCollab frmCollaborateurs;

        public ctrlListerCollaborateur()
        {
            instancieCollaborateurs();

            frmMDI.Ref.collaborateursToolStripMenuItem.Click += new System.EventHandler(this.collaborateursToolStripMenuItem_Click);
            //ShowFormListerCollab();            

              
            
        }








        private void collaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormListerCollab();
        }


        /// <summary>
        /// initialisation dialogue modal sur la liste des collaborateurs
        /// </summary>
        private void ShowFormListerCollab()
        {
            if (frmCollaborateurs == null)
            {
                frmCollaborateurs = new frmListCollab();
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

        /// <summary>
        /// initialiseListeCollab()
        /// </summary>
        private void instancieCollaborateurs()
        {
          
            Collaborateur collaborateur = new Collaborateur("M", "DUPOND", "Roger", "marie", true);
            Cdi contrat = new Cdi(new DateTime(2010, 5, 5), "Chef de Projet", "Cadre", 5000);

            collaborateur.AddContrat(contrat);
            Collaborateur.AddCollaborateur(collaborateur);
            collaborateur = new Collaborateur("Mme", "DUPONt", "Rogee", "marie", false);
            contrat = new Cdi(new DateTime(2012, 6, 6), "CDI", "employee", 1500);

            collaborateur.AddContrat(contrat);
            Collaborateur.AddCollaborateur(collaborateur);
            Console.WriteLine(contrat.ToString());

            Console.Write(Collaborateur.RestituerCollaborateur(2).ToString());
            Console.Write(collaborateur.RestituerContrat(2).ToString());
        }

    }
}
