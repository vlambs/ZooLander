using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Animaux;

namespace ZooBusiness.Animalerie
{
    public abstract class Poissons : AAnimal
    {
        public Poissons(string nom, Sexe sexe, int age, int poids, int taille) : base(nom,sexe,age,poids,taille)
        {

        }

        public Poissons(Poissons pere, Poissons mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere,mere,nom, sexe, age, poids, taille)
        {

        }
    }
}
