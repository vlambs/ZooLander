using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class PoissonChat : Poissons
    {
        public PoissonChat(PoissonChat pere, PoissonChat mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille)
        {
        }

        public PoissonChat(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille)
        {
        }
    }
}
