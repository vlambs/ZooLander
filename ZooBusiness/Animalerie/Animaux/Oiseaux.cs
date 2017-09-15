using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public abstract class Oiseaux : AAnimal<Oiseaux>
    {
        public int NombrePattes { get; set; }

        public Oiseaux(string nom, Sexe sexe, int age, int poids, int taille, int nbpattes) : base(nom,sexe,age,poids,taille)
        {
            NombrePattes = nbpattes;
        }

        public Oiseaux(Oiseaux pere, Oiseaux mere, string nom, Sexe sexe, int age, int poids, int taille, int nbpattes) : base(pere,mere,nom, sexe, age, poids, taille)
        {
            NombrePattes = nbpattes;
        }

        public override string ToString()
        {
            return string.Format("{0} J'ai {1] pattes.", base.ToString(), NombrePattes);
        }
    }
}
