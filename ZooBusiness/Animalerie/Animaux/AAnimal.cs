using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public enum NiveauFaim {Affame, Faim,Bien,Repu}
    public enum NiveauSante { Malade,Blesse,Bien }
    public enum Sexe { Male, Femelle,Hermaphrodite }
    public abstract class AAnimal<T>
    {
        public static List<AAnimal<T>> Congeneres { get; private set; } = new List<AAnimal<T>>();


        public string Nom { get; set; }
        public float Poids { get; set; }
        public int Age { get; set; }
        public int Taille { get; set; }

        public AAnimal<T> Pere { get; set; }
        public AAnimal<T> Mere { get; set; }
        public Sexe Sexe { get; set; }
        public NiveauFaim Faim { get; set; }
        public NiveauSante Sante { get; set; }

        public AAnimal(AAnimal<T> pere,AAnimal<T> mere,string nom, Sexe sexe, int age, int poids, int taille) : this (nom,sexe,age,poids,taille)
        {
            Pere = pere;
            Mere = mere;
        }

        public AAnimal(string nom, Sexe sexe, int age, int poids, int taille)
        {
            this.Nom = nom;
            this.Sexe = sexe;
            this.Age = age;
            this.Poids = poids;
            this.Taille = taille;
            
            Sante = NiveauSante.Bien;
            this.Faim = NiveauFaim.Bien;

            Congeneres.Add(this);
        }

        public AAnimal<T> Reproduction(AAnimal<T> a1, AAnimal<T> a2) 
        {
            if (a1.Sexe == a2.Sexe)
            {
                throw new ArgumentException("Deux animaux du mêmes sexe ne peuvent se reproduire !");
            }
            if (a1.Equals(a2))
            {
                throw new ArgumentException("Un animal ne peut se reproduire avec lui-même");
            }


            Random rnd = new Random();
            AAnimal<T> pere;
            AAnimal<T> mere;

            if(a1.Sexe == Sexe.Male)
            {
                pere = a1;
                mere = a2;
            }
            else
            {
                pere = a2;
                mere = a1;
            }
            return (AAnimal<T>)Activator.CreateInstance(typeof(T), new object[] { pere,mere });

        }

        public override string ToString()
        {
            return string.Format("Je suis {0} un/une {1} de sexe {4}, je pèse {2} kg et mesure {3}.", Nom, GetType().Name, Poids.ToString(), Taille.ToString(),Sexe.ToString());
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            AAnimal<T> a = obj as AAnimal<T>;

            if (this.Nom != a.Nom
                || Sexe != a.Sexe
                || Poids != a.Poids
                || Taille != a.Taille
                || Age != a.Age)
            {
                return false;
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
