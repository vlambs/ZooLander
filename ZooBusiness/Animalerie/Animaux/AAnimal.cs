using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Alimentation;
using ZooBusiness.Animalerie.Animaux;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Prix;
using ZooBusiness.Animalerie.Soins;

namespace ZooBusiness.Animalerie
{
    public enum NiveauFaim { Affame, Faim, Bien, Repu }
    public enum NiveauSante { Malade, Blesse, Bien }
    public enum Sexe { Male, Femelle, Hermaphrodite }

    public abstract class AAnimal : IPriceable
    {

        public string Nom { get; private set; }
        public float Poids { get; private set; }
        public int Age { get; private set; }
        public int Taille { get; private set; }

        public AAnimal Pere { get; private set; }
        public AAnimal Mere { get; private set; }
        public Sexe Sexe { get; private set; }
        public NiveauFaim Faim { get; set; }
        public NiveauSante Sante { get; set; }

        public int Prix { get; internal set; }

        public AAnimal(AAnimal pere, AAnimal mere,string nom, Sexe sexe, int age, int poids, int taille) : this (nom,sexe,age,poids,taille)
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
        }

        public static T Reproduction<T>(T a1, T a2) where T : AAnimal
        {
            if (a1.Sexe == a2.Sexe)
            {
                throw new SameGenderException();
            }
            if (a1.Equals(a2))
            {
                throw new SameAnimalException();
            }


            Random rnd = new Random();
            T pere;
            T mere;

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
            return CreateRandomAnimal<T>(pere, mere);

        }

        public abstract void Nourrir(INourriture food);

        public abstract void Soigner(ISoin soin);

        public void Affamer()
        {
            Faim--;
        }

        public void Blesser()
        {
            Sante--;
        }

        public static T CreateRandomAnimal<T>(T pere = null, T mere = null) where T : AAnimal
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Sexe));
            Sexe randomSexe = (Sexe)values.GetValue(random.Next(values.Length));

            return CreateRandomAnimal<T>(randomSexe,pere,mere);
        }

        public static T CreateRandomAnimal<T>(Sexe sexe,T pere = null, T mere = null) where T : AAnimal
        {
            Random random = new Random();
            int poids = random.Next(1000);
            int size = random.Next(200);
            Type t = typeof(T);
            if (pere != null && mere != null)
            {
                t = pere.GetType();
            }
            return (T)Activator.CreateInstance(t, new object[] { pere, mere, RandomUtility.RandomString(5), sexe, 0, poids, size });
        }
        public override string ToString()
        {
            return string.Format("{1} {0} de sexe {4}, pèse {2} kg et mesure {3} cm.", Nom, GetType().Name, Poids.ToString(), Taille.ToString(),Sexe.ToString());
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
