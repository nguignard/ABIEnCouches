using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEnCouches
{
    class ctrlAjouterCollaborateur
    {
        Collaborateur leCollaborateur;
        frmAjouterCollab leForm;

       public ctrlAjouterCollaborateur()
        {
            leForm = new frmAjouterCollab();
           
            this.leForm.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click);
            this.leForm.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            this.leForm.ShowDialog();

        }





        private void btnValider_Click(object sender, EventArgs e)
        {
            this.leForm.Instancie();
        }


        private void btnAjouterPhoto_Click(object sender, EventArgs e)
        {
            //TODO
        }





    }
}
