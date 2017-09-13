using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{
    public class Vivarium : AStructure<Reptiles>
    {
        public Vivarium()
        {
            this.Environnement = TypeEnvironnement.TerreBattue;
            this.Fermeture = TypeFermeture.Verre;
        }
    }
}
