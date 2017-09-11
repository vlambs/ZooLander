using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Elephant : Mammiferes
    {
        public override string presentation()
        {
            string res;
            if (this.sexe == "male")
                res = "Je suis "+this.nom+" l'éléphant de "+this.poids.ToString() + "kg et de "+this.taille.ToString() + ". J'ai "+this.pattes.ToString()+" pattes.";
            else
                res = "Je suis " + this.nom + " l'éléphante de " + this.poids.ToString() + "kg et de " + this.taille.ToString() + ". J'ai " + this.pattes.ToString() + " pattes.";
            return res;
        }
    }
}
