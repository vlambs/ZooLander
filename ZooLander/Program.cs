using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            try { 
                ZooSimulator zoo = ZooSimulator.Instance;
                TimeSpan ts = new TimeSpan(0, 2, 0);
                Timer t = new Timer(Routine,null,ts.Milliseconds,Timeout.Infinite);
                zoo.ZooLander.CommanderStructure(new Enclos());
                Enclos enclos = (Enclos)zoo.ZooLander.Structures.First();
                Elephant e1 = AAnimal.CreateRandomAnimal<Elephant>(Sexe.Male);
                Console.WriteLine(e1.ToString());
                Elephant e2 = AAnimal.CreateRandomAnimal<Elephant>(Sexe.Femelle);
                Console.WriteLine(e2.ToString());
                zoo.ZooLander.CommanderAnimal(e1,enclos);
                zoo.ZooLander.CommanderAnimal(e2,enclos);
                zoo.ZooLander.Reproduire(e1, e2,enclos);
                Console.WriteLine("Reproduction En Cours !");
                Console.WriteLine(enclos.Animaux[2].ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void Routine(object state)
        {
            ZooSimulator.Instance.Routine();
        }
    }
}
