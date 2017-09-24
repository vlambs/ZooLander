using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.StructuresZoo.Models;

namespace ZooLander
{
    class Program
    {
        static Timer myTimer;
        static void Main(string[] args)
        {
            ZooSimulator zoo = ZooSimulator.Instance;
            try
            {

                TimeSpan ts = new TimeSpan(0, 0, 20);
                myTimer = new Timer(ts.TotalMilliseconds);
                myTimer.Elapsed += async (sender, e) => Routine();
                myTimer.Start();

                //ELEPHANTS
                //Création d'une structure enclos
                zoo.ZooLander.CommanderStructure(new Enclos());
                Enclos enclos = (Enclos)zoo.ZooLander.Structures.First();
                //Génération de deux éléphants m/f
                Elephant e1 = AAnimal.CreateRandomAnimal<Elephant>(Sexe.Male);
                Console.WriteLine(e1.ToString());
                Elephant e2 = AAnimal.CreateRandomAnimal<Elephant>(Sexe.Femelle);
                Console.WriteLine(e2.ToString());
                //Affectation des deux éléphants à leurs enclos
                zoo.ZooLander.CommanderAnimal(e1, enclos);
                zoo.ZooLander.CommanderAnimal(e2, enclos);
                //Reproduction des deux éléphants
                zoo.ZooLander.Reproduire(e1, e2, enclos);
                Console.WriteLine("Reproduction d'éléphants en cours !");
                Console.WriteLine(enclos.Animaux[2].ToString());

                //PERROQUETS
                //Creation d'une structure volerie
                zoo.ZooLander.CommanderStructure(new Volerie());
                Volerie volerie = (Volerie)zoo.ZooLander.Structures[1];

                //Génération de trois perroquets m/m/f
                Perroquet p1 = AAnimal.CreateRandomAnimal<Perroquet>(Sexe.Male);
                Console.WriteLine(p1.ToString());
                Perroquet p2 = AAnimal.CreateRandomAnimal<Perroquet>(Sexe.Male);
                Console.WriteLine(p2.ToString());
                Perroquet p3 = AAnimal.CreateRandomAnimal<Perroquet>(Sexe.Femelle);
                Console.WriteLine(p3.ToString());
                //Affectation des deux éléphants à leurs enclos
                Console.WriteLine("Un éléphant dans une volerie? Challenge accepted!");
                zoo.ZooLander.CommanderAnimal(e1, volerie); // test si l'on peut ajouter un éléphant dans une volerie
                zoo.ZooLander.CommanderAnimal(p1, volerie);
                zoo.ZooLander.CommanderAnimal(p2, volerie);
                zoo.ZooLander.CommanderAnimal(p3, volerie);
                //Reproduction de deux perroquets m/f
                zoo.ZooLander.Reproduire(p1, p3, volerie);
                Console.WriteLine("Reproduction de perroquets en cours !");
                Console.WriteLine(volerie.Animaux[3].ToString());
                //Reproduction de deux perroquets m/m
                Console.WriteLine(string.Format("{0} et {1} tentent l'impossible, qu'arrivera-t-il?", p1.Nom, p2.Nom));
                try
                {
                    zoo.ZooLander.Reproduire(p1, p2, volerie);
                    Console.WriteLine(volerie.Animaux[4].ToString());
                }
                catch 
                {
                }
                //Création des structures de test
                zoo.ZooLander.CommanderStructure(new Enclos());
                Enclos enclosTest = (Enclos)zoo.ZooLander.Structures[zoo.ZooLander.Structures.Count-1];
                zoo.ZooLander.CommanderStructure(new Vivarium());
                Vivarium vivariumTest = (Vivarium)zoo.ZooLander.Structures[zoo.ZooLander.Structures.Count - 1];
                zoo.ZooLander.CommanderStructure(new Aquarium());
                Aquarium aquariumTest = (Aquarium)zoo.ZooLander.Structures[zoo.ZooLander.Structures.Count - 1];
                zoo.ZooLander.CommanderStructure(new Volerie());
                Volerie volerieTest = (Volerie)zoo.ZooLander.Structures[zoo.ZooLander.Structures.Count - 1];
                //Ajout évènements utilisateur
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try { 

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Veuillez entrer le nom d'une action utilisateur");
                    GestionUtilisateur(zoo, zoo.ZooLander.Animaux, zoo.ZooLander.Structures, zoo.ZooLander.Tresorerie.Caisse);
                }
            }
            catch
            {

            }

            Console.ReadLine();
        }

        public static void Routine()
        {
            myTimer.Stop();
            ZooSimulator.Instance.Routine();
            myTimer.Start();
        }
        public static void GestionUtilisateur(ZooSimulator zoo, List<AAnimal> listeAnimaux, List<IStructure> listeStructures, int argent)
        {
            string choix = "";
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Actions possibles: listeAnimaux - Structures - lesboulasses - miseencage");
            Console.WriteLine("*********************");
            choix = Console.ReadLine();
            switch (choix.ToUpper())
            {
                case "LISTEANIMAUX":
                    //Affichage de la liste des animaux
                    Console.WriteLine(listeAnimauxToString(listeAnimaux));
                    break;
                case "STRUCTURES":
                    //Affichage de la liste des structures
                    Console.WriteLine(string.Format("Nombre de structures: {0} ", listeStructures.Count()));
                    
                    break;
                case "LESBOULASSES":
                    //Affichage de la thune
                    Console.WriteLine(boulasseDisplayHandler(argent));
                    Console.WriteLine(string.Format("Argent Restant : {0}", argent));
                    break;
                case "MISEENCAGE":
                    //Affichage de la thune
                    MiseEnCageHandler(zoo, listeAnimaux);
                    break;
                default:
                    Console.WriteLine("T'es pas marrant...");
                    break;
            }
        }
        public static string listeAnimauxToString(List<AAnimal> listeAnimaux)
        {
            string res = "";
            foreach (var a in listeAnimaux)
            {
                if (res != "")
                    res = res + "; ";
                res = res + string.Format("({0})", a.GetType().Name) + a.Nom;
            }
            return res;
        }
        public static string boulasseDisplayHandler(int boulasse)
        {
            string res = "";
            if (boulasse < 500)
                res = "Mec t'es fauché de ouf!";
            else
                res = "Ez moneyyyy morrayyy!";
            return res;
        }
        public static void MiseEnCageHandler(ZooSimulator zoo, List<AAnimal> listeAnimaux)
        {
            string choix = "";
            Console.WriteLine("Choisissez un animal à mettre en cage: " + listeAnimauxToString(listeAnimaux));
            choix = Console.ReadLine();
            foreach (var a in listeAnimaux)
            {
                if (a.Nom.ToUpper() == choix.ToUpper())
                {
                    zoo.ZooLander.CommanderAnimal(a);
                }
            }

        }

    }
}
