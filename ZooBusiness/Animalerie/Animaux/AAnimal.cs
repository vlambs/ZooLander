using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class AAnimal
    {
        public string nom { get; set; }
        public float poids { get; set; }
        public int age { get; set; }
        public float taille { get; set; }
        public string sexe { get; set; }
        public int pattes { get; set; }
        public int niveauFaim { get; set; }
    }

}
