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
    public class Perroquet : Oiseaux
    {
        public Perroquet(Perroquet pere, Perroquet mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille, 2)
        {
        }

        public Perroquet(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille, 2)
        {
        }

        public override void Nourrir(INourriture food)
        {
            Faim++;
        }

        public override void Soigner(ASoins soin)
        {
            Sante++;
        }
    }
}
