using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public enum NiveauFaim {AFFAME, MOYEN,PASFAIM}
    public abstract class AAnimal
    {
        public string nom { get; set; }
        public float poids { get; set; }
        public int age { get; set; }
        public string pere { get; set; }
        public string mere { get; set; }
        public int taille { get; set; }
        public string sexe { get; set; }
        public int pattes { get; set; }
        public NiveauFaim faim { get; set; }
        public abstract void Reproduction(AAnimal a2);
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}
