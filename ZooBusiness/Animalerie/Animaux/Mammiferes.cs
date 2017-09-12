using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class Mammiferes : AAnimal
    {
        public Mammiferes(string nom,Sexe sexe,int age,int poids,int taille, int nbPattes) : base(nom,sexe,age,poids,taille,nbPattes)
        {

        }

        public Mammiferes(Mammiferes pere, Mammiferes mere,string nom, Sexe sexe, int age, int poids, int taille,int nbPattes) : base(pere,mere,nom, sexe, age, poids, taille, nbPattes)
        {

        }
    }
}
