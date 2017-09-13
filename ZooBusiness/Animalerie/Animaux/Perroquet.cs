using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
