using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooLander
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elep = new Elephant("Michael", Sexe.Male, 0, 150, 160);
            Console.WriteLine(elep);
            Console.ReadLine();
        }
    }
}
