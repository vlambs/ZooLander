﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBusiness.Animalerie
{
    public class Perroquet : Oiseaux
    {
        public override string presentation()
        {
            string res = "Je suis " + this.nom + " le perroquet de " + this.poids.ToString() + "kg et de " + this.taille.ToString() + ". J'ai " + this.pattes.ToString() + " pattes.";
            return res;
        }
    }
}
