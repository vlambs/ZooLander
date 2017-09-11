using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class EntreeReduite : Entree
    {

        public override int Prix { get { return basePrix/2; } }
    }
}
