using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.StructuresZoo.Models;

namespace ZooBusiness.OrganisationZoo.Models
{
    public class Entretien : Employe
    {
        public Entretien() : base()
        {
            
        }

        public void Reparer(IStructure structure)
        {
            structure.Reparer();
            
        }
    }
}
