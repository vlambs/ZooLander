using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Giraffe : Mammiferes
    {
        public override string presentation()
        {
            string res = "Je suis " + this.nom + " la giraffe de " + this.poids.ToString() + "kg et de " + this.taille.ToString() + ". J'ai " + this.pattes.ToString() + " pattes.";
            return res;
        }
        public static List<Giraffe> listeGiraffes;
        public void Reproduction(Giraffe e2)
        {
            Random rnd = new Random();
            string pere;
            string mere;
            if (this.sexe != e2.sexe)
            {
                if (this.sexe == "male")
                {
                    pere = this.nom;
                    mere = e2.nom;
                }
                else
                {
                    pere = e2.nom;
                    mere = this.nom;
                }
                Task t = new Task(() => AjoutAnimal(pere, mere));
                Task.Delay(12000);
                t.Start();
            }
        }
        public static void AjoutAnimal(string pere, string mere)
        {
            // Ajout d'un elephant
            listeGiraffes.Add(new Giraffe(pere, mere));
        }

        public override void Reproduction(AAnimal a2)
        {
            if (this.Equals(a2))
                throw new Exception("Cet animal ne peut pas se reproduire avec lui même, beurk...");
            else
                this.Reproduction((Giraffe)a2);
        }

        public Giraffe(string pere, string mere)
        {
            this.pere = pere;
            this.mere = mere;
            Random rnd = new Random();
            this.age = 0;
            this.nom = RandomString(rnd.Next(3, 15));
            if (rnd.Next(0, 1) == 0)
                this.sexe = "femelle";
            else
                this.sexe = "male";
            this.poids = rnd.Next(40, 80);
            this.taille = rnd.Next(200,250);
            this.pattes = 4;
            this.niveauFaim = 3;
        }
        public Giraffe(string nom, string sexe, int age, int poids, int taille)
        {
            this.nom = nom;
            this.sexe = sexe;
            this.age = age;
            this.poids = poids;
            this.taille = taille;
            this.pattes = 4;
            this.niveauFaim = 3;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Giraffe elep = obj as Giraffe;
            if (this.nom == elep.nom && this.mere == elep.mere && this.pere == elep.pere && this.age == elep.age)
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
    }
}
