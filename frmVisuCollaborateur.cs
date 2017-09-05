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
    public partial class frmVisuCollaborateur : Form
    {

        Collaborateur leCollaborateur;

        public frmVisuCollaborateur(Collaborateur unCollab)
        {
            this.leCollaborateur = unCollab;
            InitializeComponent();

            this.Text = this.leCollaborateur.ToString();
            this.txtNumeroMatricule.Text = unCollab.Matricule.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void frmVisuCollaborateur_Load(object sender, EventArgs e)
        {

        }
    }
}
