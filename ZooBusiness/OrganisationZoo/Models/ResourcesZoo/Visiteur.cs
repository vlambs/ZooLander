using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.OrganisationZoo.Models.ResourcesZoo
{
    public class Visiteur
    {
        public Entree Ticket { get; private set; }

        public int Age { get; private set; }

        public Visiteur(int age)
        {
            Age = age;
        }

        public Entree AcheterTicket()
        {
            return Ticket = this.Age < 16 ? new EntreeReduite() : new Entree();
        }
    }
}
