using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.OrganisationZoo.Models
{
    public abstract class Employe
    {
        public int Id { get; private set; }

        public static int Salaire { get; private set; }

        public Employe Responsable { get; private set; }

        public IEnumerable<Employe> Subordonnes { get; private set;}
    }
}
