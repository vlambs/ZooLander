using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class Reptiles : AAnimal<Reptiles>
    {
        public Reptiles(string nom, Sexe sexe, int age, int poids, int taille) : base(nom,sexe,age,poids,taille)
        {

        }

        public Reptiles(Reptiles pere, Reptiles mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere,mere,nom, sexe, age, poids, taille)
        {

        }
    }
}
