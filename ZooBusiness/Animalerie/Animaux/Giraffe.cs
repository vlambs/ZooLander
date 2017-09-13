using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Giraffe : Mammiferes
    {

        public Giraffe(Giraffe pere, Giraffe mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille,4)
        {
        }

        public Giraffe(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille,4)
        {
        }
    }
}
