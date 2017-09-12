using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class Reptiles : AAnimal
    {
        public Reptiles(string nom, Sexe sexe, int age, int poids, int taille, int nbpattes) : base(nom,sexe,age,poids,taille,nbpattes)
        {

        }

        public Reptiles(Reptiles pere, Reptiles mere, string nom, Sexe sexe, int age, int poids, int taille, int nbpattes) : base(pere,mere,nom, sexe, age, poids, taille, nbpattes)
        {

        }
    }
}
