using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class Entree
    {
        internal static int basePrix = 10;

        public virtual int Prix { get { return basePrix; } }
    }
}
