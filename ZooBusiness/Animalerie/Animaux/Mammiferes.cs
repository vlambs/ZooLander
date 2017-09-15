using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class Mammiferes : AAnimal<Mammiferes>
    {
        public int NombrePattes { get; set; }

        public Mammiferes(string nom,Sexe sexe,int age,int poids,int taille, int nbPattes) : base(nom,sexe,age,poids,taille)
        {
            NombrePattes = nbPattes;
        }

        public Mammiferes(Mammiferes pere, Mammiferes mere,string nom, Sexe sexe, int age, int poids, int taille,int nbPattes) : base(pere,mere,nom, sexe, age, poids, taille)
        {
            NombrePattes = nbPattes;
        }

        public override string ToString()
        {
            return string.Format("{0} J'ai {1] pattes.",base.ToString(),NombrePattes);
        }
    }
}
