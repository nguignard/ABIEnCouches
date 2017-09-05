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
    

    public partial class frmListCollab : Form
    {

        //private Collaborateurs listeCollaborateurs;

        public frmListCollab(Collaborateurs listeCollaborateurs)
        {
            InitializeComponent();
            this.afficheCollaborateurs(listeCollaborateurs);
        }

        internal void afficheCollaborateurs(Collaborateurs listeCollaborateurs)
        {
            this.grdCollaborateurs.DataSource = listeCollaborateurs.ListeCollaborateurs();
            this.grdCollaborateurs.Refresh();
            this.btnFermer.Enabled = true;
                //(this.grdCollaborateurs.CurrentRow == null ? false : true);
        }




        /// <summary>
        /// btnFermer_Click ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
