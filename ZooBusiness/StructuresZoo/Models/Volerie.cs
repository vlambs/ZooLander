using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{
    public class Volerie : AStructure<Oiseaux>
    {
        public Volerie()
        {
            this.Environnement = TypeEnvironnement.Branchages;
            this.Fermeture = TypeFermeture.Cage;
            Prix = 1000;
        }
    }
}
