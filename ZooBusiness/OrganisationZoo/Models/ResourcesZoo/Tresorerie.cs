using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Prix;

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

        public void Depenser(IPriceable objet)
        {
            if(Caisse > objet.Prix) { 
                Caisse -= objet.Prix;
            }
            else
            {
                throw new NotEnoughMoneyException();
            }
        }

        public Tresorerie(Tresorier tresorier,int baseSomme)
        {
            Tresorier = tresorier;
            Caisse = baseSomme;
        }
    }
}
