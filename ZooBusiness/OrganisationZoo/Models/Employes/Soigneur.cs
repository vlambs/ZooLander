using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;

namespace ZooBusiness.OrganisationZoo.Models
{
    public class Soigneur : Employe
    {
        public Soigneur() : base()
        {
            
        }
        public void Nourrir<T>(AAnimal<T> animal,INourriture food)
        {
            animal.Nourrir(food);
        }

        public void Soigner<T>(AAnimal<T> animal, ISoin soin)
        {
            animal.Soigner(soin);
        }
    }
}
