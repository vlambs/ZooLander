using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class Tresorerie
    {
        public Tresorier Tresorier {get; private set; }

        public int Caisse { get; private set; }

        public int NombreEntrees { get; private set; }

        public void ComptabiliserEntree(Entree entree)
        {
            Caisse += entree.Prix;
            NombreEntrees += 1;
        }

        public void Depenser(int depense)
        {
            Caisse -= depense;
        }
    }
}
