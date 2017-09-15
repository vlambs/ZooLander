using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;
using ZooBusiness.StructuresZoo.Models;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class Stock
    {
        public Magasinier Magasinier { get; private set; }
        public List<ISoin> Soins { get; set; } = new List<ISoin>();

        public List<INourriture> Nourritures { get; private set; } = new List<INourriture>();

        public List<IStructure> Structures { get; internal set; } = new List<IStructure>();
    }
}
