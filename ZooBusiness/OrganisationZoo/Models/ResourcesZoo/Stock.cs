using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class Stock
    {
        public Magasinier Magasinier { get; private set; }
        public List<ASoins> Soins { get; set; }

        public List<INourriture> Nourritures { get; private set; }

        public void CommanderSoin(ASoins soin)
        {
            Soins.Add(soin);
        }

        public void UtiliserSoin(ASoins soin)
        {
            Soins.Remove(soin);
        }

        public void CommanderNourriture(INourriture nourriture)
        {
            Nourritures.Remove(nourriture);
        }

        public void UtiliserNourriture(INourriture nourriture)
        {
            Nourritures.Add(nourriture);
        }
    }
}
