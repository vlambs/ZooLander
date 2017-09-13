using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Vipere : Reptiles
    {

        public Vipere(Vipere pere, Vipere mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille)
        {
        }

        public Vipere(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille)
        {
        }

    }
}
