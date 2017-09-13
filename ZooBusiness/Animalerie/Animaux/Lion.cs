using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Lion : Mammiferes
    {

        public Lion(Giraffe pere, Giraffe mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille,4)
        {
        }

        public Lion(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille, 4)
        {
        }
    }
}
