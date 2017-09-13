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
    public class PoissonChat : Poissons
    {
        public PoissonChat(PoissonChat pere, PoissonChat mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille)
        {
            Congeneres.Add(this);
        }

        public PoissonChat(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille)
        {
            Congeneres.Add(this);
        }

        public override void Nourrir(INourriture food)
        {
            if (!(food is IGraine))
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
