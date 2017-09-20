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
            int prob;
            foreach (var a in ZooLander.Animaux)
            {
                Console.WriteLine( a.ToString());
                prob = gen.Next(100);
                if (prob <= 3)
                {
                    a.Blesser();
                    Console.WriteLine(string.Format("{0} a été blessé. Etat :", a, a.Sante));
                    int chance = gen.Next(100);
                    if (chance < 5)
                    {
                        a.Blesser();
                        Console.WriteLine(string.Format("Ouch, {0} se blesse à nouveau. Etat :", a.Nom, a.Sante));
                    }
                    else
                    {
                        Console.WriteLine("Un soigneur s'en occupe ");
                        // bug --> a.Soigner(ZooLander.Stock.Soins); //utiliser correctement Soigner(), comment on sélectionne le bon soin?
                        Console.WriteLine(string.Format("{0} a été soigné! Etat :", a.Nom, a.Sante));
                    }
                    
                }
                prob = gen.Next(100);
                if (prob <= 10)
                {
                    a.Affamer();
                    Console.WriteLine(string.Format("{0} a faim. Etat :", a, a.Faim));
                    prob = gen.Next(100);
                    if (prob < 3)
                    {
                        Console.WriteLine(string.Format("{0} a mangé un enfant qui été trop proche. Etat :", a, a.Nourrir(food))); //utiliser correctement nourrir(), comment on sélectionne la bonne nourriture?
                    }
                }
                //a.Age++; bug
                prob = gen.Next(8);
                if(prob > 7)
                {
                    Console.WriteLine(string.Format("{0} est mort de veillesse.", a.Nom));
                    ZooLander.Animaux.Remove(a);
                }
            }
            foreach (var s in ZooLander.Structures)
            {
                Console.WriteLine(s.ToString());
                prob = gen.Next(100);
                if (prob <= 3)
                {
                    if (s.Animaux.Count() < 4)
                    {
                        s.AjouterAnimal(ZooLander.Animaux.ElementAt(prob));
                        //retirer l'animal de sa précédente structure
                    }
                }
                if(prob > 80)
                {
                    s.Casser();
                }
                if(prob<80 && prob>3)
                {
                    s.Reparer();
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
            foreach( var v in ZooLander.Visiteurs)
            {
                v.AcheterTicket();
            }
        
        }
    }
}
