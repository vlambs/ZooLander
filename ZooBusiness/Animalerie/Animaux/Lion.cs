using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Alimentation;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;

namespace ZooBusiness.Animalerie
{
    public class Lion : Mammiferes
    {

        public Lion(Giraffe pere, Giraffe mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille,4)
        {
            Prix = 1500;
        }

        public Lion(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille, 4)
        {
            Prix = 1500;
        }

        public override void Nourrir(INourriture food)
        {
            if (!(food is IAnimal))
            {
                throw new ArgumentException("Mauvais régime");

            }

            Faim++;
        }

        public override void Soigner(ISoin soin)
        {
            Sante++;
        }
    }
}
