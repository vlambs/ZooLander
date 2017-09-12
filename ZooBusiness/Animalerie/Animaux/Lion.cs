using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Lion : Mammiferes
    {

        public static List<Lion> listeLions;


        public Lion(Giraffe pere, Giraffe mere, string nom, Sexe sexe, int age, int poids, int taille) : base(pere, mere, nom, sexe, age, poids, taille,4)
        {
        }

        public Lion(string nom, Sexe sexe, int age, int poids, int taille) : base(nom, sexe, age, poids, taille, 4)
        {
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Lion elep = obj as Lion;
            if (this.Nom == elep.Nom && this.Mere == elep.Mere && this.Pere == elep.Pere && this.Age == elep.Age)
            {
                return true;
            }
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        public override void AjoutAnimal(AAnimal pere, AAnimal mere)
        {
            throw new NotImplementedException();
        }
    }
}
