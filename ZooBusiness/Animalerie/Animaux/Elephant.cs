using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Elephant : Mammiferes
    {
        public static List<Elephant> listeElephants;
        public override string presentation()
        {
            string res;
            if (this.sexe == "male")
                res = "Je suis "+this.nom+" l'éléphant de "+this.poids.ToString() + "kg et de "+this.taille.ToString() + ". J'ai "+this.pattes.ToString()+" pattes.";
            else
                res = "Je suis " + this.nom + " l'éléphante de " + this.poids.ToString() + "kg et de " + this.taille.ToString() + ". J'ai " + this.pattes.ToString() + " pattes.";
            return res;
        }
        public void Reproduction(Elephant e2)
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
                Task.Delay(15000);
                t.Start();
            }
        }
        public static void AjoutAnimal(string pere, string mere)
        {
            // Ajout d'un elephant
            listeElephants.Add(new Elephant(pere, mere));
        }

        public override void Reproduction(AAnimal a2)
        {
            if (this.Equals(a2))
                throw new Exception("Cet animal ne peut pas se reproduire avec lui même, beurk...");
            else
                this.Reproduction((Elephant)a2);
        }

        public Elephant (string pere, string mere)
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
            this.poids = rnd.Next(100, 140);
            this.taille = rnd.Next(100, 120);
            this.pattes = 4;
            this.niveauFaim = 3;
        }
        public Elephant(string nom, string sexe, int age, int poids, int taille)
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
            Elephant elep = obj as Elephant;
            if(this.nom == elep.nom && this.mere == elep.mere && this.pere == elep.pere && this.age == elep.age)
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
