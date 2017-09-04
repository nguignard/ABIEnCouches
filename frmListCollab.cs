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
        public frmListCollab()
        {
            InitializeComponent();
            afficheCollaborateurs();
        }

        private void afficheCollaborateurs()
        {
            
            this.grdCollaborateurs.DataSource = Collaborateur.GetCollaborateurs();



            this.grdCollaborateurs.Refresh();

            this.btnArchiver.Enabled = (this.grdCollaborateurs.CurrentRow == null ? false : true);


        }

         












    }
}
