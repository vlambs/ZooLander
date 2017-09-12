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
    public abstract class AAnimal
    {
        public string Nom { get; set; }
        public float Poids { get; set; }
        public int Age { get; set; }
        public AAnimal Pere { get; set; }
        public AAnimal Mere { get; set; }
        public int Taille { get; set; }
        public Sexe Sexe { get; set; }
        public int NombrePattes { get; set; }
        public NiveauFaim Faim { get; set; }

        public NiveauSante Sante { get; set; }

        public AAnimal(AAnimal pere,AAnimal mere,string nom, Sexe sexe, int age, int poids, int taille,int nbPattes) : this (nom,sexe,age,poids,taille,nbPattes)
        {
            Pere = pere;
            Mere = mere;
        }

        public AAnimal(string nom, Sexe sexe, int age, int poids, int taille,int nbPattes)
        {
            this.Nom = nom;
            this.Sexe = sexe;
            this.Age = age;
            this.Poids = poids;
            this.Taille = taille;
            this.Faim = NiveauFaim.Bien;
            NombrePattes = nbPattes;
            Sante = NiveauSante.Bien;
        }

        public T Reproduction<T>(T a1,T a2) where T : AAnimal
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
            AAnimal pere;
            AAnimal mere;

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
            return (T)Activator.CreateInstance(typeof(T), new object[] { pere,mere });

        }

        public abstract void AjoutAnimal(AAnimal pere, AAnimal mere);

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public override string ToString()
        {
            return string.Format("Je suis {0} un/une {1} de sexe {5}, je pèse {2} kg et mesure {3}. J'ai {4} pattes", Nom, GetType().Name, Poids.ToString(), Taille.ToString(), NombrePattes.ToString(),Sexe.ToString());
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

            AAnimal a = obj as AAnimal;

            if (this.Nom != a.Nom
                || NombrePattes != a.NombrePattes
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
