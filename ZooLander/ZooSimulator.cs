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
            ZooLander = new Zoo(30000);
        }

        public void Routine()
        {
            Console.WriteLine();
            Console.WriteLine("************* Début Routine *************");
            Console.WriteLine();
            Random gen = new Random();
            int prob;
            foreach (var a in ZooLander.Animaux)
            {
                Console.WriteLine(a.ToString());
                prob = gen.Next(100);
                if (prob <= 3)
                {
                    a.Blesser();
                    Console.WriteLine(string.Format("{0} a été blessé. Etat : {1}", a, a.Sante.ToString()));
                    int chance = gen.Next(100);
                    if (chance < 5)
                    {
                        a.Blesser();
                        Console.WriteLine(string.Format("Ouch, {0} se blesse à nouveau. Etat {1} :", a.Nom, a.Sante.ToString()));
                    }
                    else
                    {
                        Console.WriteLine("Un soigneur s'en occupe ");
                        // bug --> a.Soigner(ZooLander.Stock.Soins); //utiliser correctement Soigner(), comment on sélectionne le bon soin?
                        Console.WriteLine(string.Format("{0} a été soigné! Etat {1} :", a.Nom, a.Sante.ToString()));
                    }

                }
                prob = gen.Next(100);
                if (prob <= 10)
                {
                    a.Affamer();
                    Console.WriteLine(string.Format("{0} a faim. Etat {1} :", a, a.Faim));
                    //prob = gen.Next(100);
                    //if (prob < 3)
                    //{
                    //    Console.WriteLine(string.Format("{0} a mangé un enfant qui été trop proche. Etat :", a, a.Nourrir(food))); //utiliser correctement nourrir(), comment on sélectionne la bonne nourriture?
                    //}
                }
                prob = gen.Next(8);
                if (prob > 7)
                {
                    Console.WriteLine(string.Format("{0} est mort de veillesse.", a.Nom));
                    ZooLander.Animaux.Remove(a);
                }
            }
            foreach (var s in ZooLander.Structures)
            {
                Console.WriteLine(s.ToString());
                prob = gen.Next(100);
                if (prob > 80)
                {
                    s.Casser();
                    Console.WriteLine(string.Format("Une structure s'est cassée. Etat: {0} ", s.Etat.ToString()));
                }
                if (prob < 80)
                {
                    s.Reparer();
                    Console.WriteLine(string.Format("Une structure s'est réparée. Etat: {0} ", s.Etat.ToString()));
                }

            }
            /*int compteAvant =  ZooLander.Tresorerie.Caisse;
            prob = gen.Next(10, 1000);
            int prob2 = gen.Next(prob);
            int num = prob - prob2;
            for(int i = 0; i < prob2; i++){
                ZooLander.Tresorerie.ComptabiliserEntree(ZooLander.Visiteurs.  ZooBusiness.OrganisationZoo.Models.ResourcesZoo.Entree); // bug
            }
            Console.WriteLine(string.Format("{0} d'entrées ont été vendues. Argent: {1}. Gain: ", prob2, ZooLander.Tresorerie.Caisse.ToString(), (ZooLander.Tresorerie.Caisse - compteAvant).ToString()));
            for(int j = 0; j < num; j++){
                ZooLander.Tresorerie.ComptabiliserEntree(ZooBusiness.OrganisationZoo.Models.ResourcesZoo.EntreeReduite); //bug
            }
            compteAvant =  ZooLander.Tresorerie.Caisse;
            Console.WriteLine(string.Format("{0} d'entrées ont été vendues. Argent: {1}. Gain: ", num, ZooLander.Tresorerie.Caisse.ToString(), (ZooLander.Tresorerie.Caisse - compteAvant).ToString()));*/
            foreach (var v in ZooLander.Visiteurs)
            {
                v.AcheterTicket();
            }
            Console.WriteLine();
            Console.WriteLine("************* Fin Routine *************");
            Console.WriteLine();
        }
    }
}
