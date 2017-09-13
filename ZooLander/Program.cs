using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.StructuresZoo.Models;

namespace ZooLander
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elep = new Elephant("Michael", Sexe.Male, 0, 150, 160);
            Giraffe gir = new Giraffe("Michael", Sexe.Male, 0, 150, 160);
            PoissonChat pc = new PoissonChat("DZD", Sexe.Femelle, 0, 200, 200);
            Enclos nc = new Enclos();
            nc.Animaux.Add(elep);
            Console.WriteLine(elep.Faim);
            elep.Nourrir(new Herbe());
            Console.WriteLine(elep.Faim);
            Console.ReadLine();
        }
    }
}
