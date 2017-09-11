using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.OrganisationZoo.Models;
using ZooBusiness.OrganisationZoo.Models.ResourcesZoo;

namespace ZooBusiness.OrganisationZoo.Controllers
{
    public class Gestionnaire
    {
        public IEnumerable<Visiteur> Visiteurs { get; private set; }

        public Stock Stock { get; private set; }

        public Tresorerie Tresorerie { get; private set; }

        public Directeur Directeur { get; }
    }
}
