using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIEnCouches
{
    public class ctrlListerCollaborateur
    {

        public ctrlListerCollaborateur()
        {
            initialiseListeCollab();
        }






        private void initialiseListeCollab()
        {
            Collaborateur.Collaborateurs = new System.Collections.Generic.SortedDictionary<int, Collaborateur>();
            Collaborateur collaborateur = new Collaborateur("M", "DUPOND", "Roger", "marie", true);
            Cdi contrat = new Cdi(new DateTime(2010, 5, 5), "Chef de Projet", "Cadre", 5000);

            collaborateur.AddContrat(contrat);
            collaborateur.AddCollaborateur(collaborateur);
            collaborateur = new Collaborateur("Mme", "DUPONt", "Rogee", "marie", false);
            contrat = new Cdi(new DateTime(2012, 6, 6), "CDI", "employee", 1500);

            collaborateur.AddContrat(contrat);
            collaborateur.AddCollaborateur(collaborateur);
            Console.WriteLine(contrat.ToString());

            Console.Write(collaborateur.RestituerCollaborateur(2).ToString());
            Console.Write(collaborateur.RestituerContrat(2).ToString());
        }




    }
}
