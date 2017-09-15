using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{
    public class Aquarium : AStructure<Poissons>
    {
        public Aquarium()
        {
            this.Environnement = TypeEnvironnement.Eau;
            this.Fermeture = TypeFermeture.Verre;
            Prix = 2000;
        }
    }
}
