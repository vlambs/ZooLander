using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.OrganisationZoo.Controllers;

namespace ZooLander
{
    public class ZooSimulator
    {
        private static ZooSimulator instance = null;

        public Zoo ZooLander { get; private set; }

        public static ZooSimulator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZooSimulator();
                }
                return instance;
            }
        }

        private ZooSimulator()
        {
            ZooLander = new Zoo(3000);
        }

        public void Routine()
        {
            Random gen = new Random();
            foreach (var a in ZooLander.Animaux)
            {
                int prob = gen.Next(100);
                if (prob <= 3)
                {
                    a.Blesser();
                    Console.WriteLine(string.Format("{0} a été blessé. Etat :", a, a.Sante));

                }
                prob = gen.Next(100);
                if (prob <= 10)
                {
                    a.Affamer();
                    Console.WriteLine(string.Format("{0} a faim. Etat :", a, a.Faim));
                }
            }
            foreach (var s in ZooLander.Structures)
            {
                int prob = gen.Next(100);
                if (prob <= 3)
                {
                    if (s.Animaux.Count() > 1)
                    {

                    }
                }
            }
        }
    }
}
