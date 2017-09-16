using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{
    public class Enclos : AStructure<Mammiferes>
    {
        public Enclos()
        {
            this.Environnement = TypeEnvironnement.Herbe;
            this.Fermeture = TypeFermeture.Barrière;
            Prix = 1000;
        }
    }
}
