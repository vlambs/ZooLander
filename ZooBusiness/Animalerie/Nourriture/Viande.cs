﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie.Alimentation;

namespace ZooBusiness.Animalerie.Nourriture
{
    public class Viande : IAnimal
    {
        public int Prix { get; } = 100;
    }
}
