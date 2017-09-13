using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Alimentation;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;

namespace ZooBusiness.Animalerie
{
    public class Elephant : Mammiferes
    {
        public Elephant(Elephant pere, Elephant mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille,4)
        {

        }

        public Elephant(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille,4)
        {
        }

        public override void Nourrir(INourriture food)
        {
            if(!(food is IVegetal))
            {
                throw new ArgumentException("Mauvais régime");

            }

            Faim++;
        }

        public override void Soigner(ASoins soin)
        {
            Sante++;
        }
    }
}
