using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{
    public enum TypeEnvironnement { TerreBattue,Herbe,Foret,Eau,Branchages}
    public enum TypeFermeture { Grillage, Barrière, Cage, Verre}

    public enum EtatStructure { Delabre,Endommage,Bien,Parfait}

    public abstract class AStructure<T> where T : AAnimal<T>
    {
        private static int id = 0;

        public int Id { get; private set; }
        public TypeEnvironnement Environnement { get; private set; }

        public TypeFermeture Fermeture { get; private set; }

        public EtatStructure Etat { get; private set; } = EtatStructure.Parfait;

        public List<T> Animaux { get; private set; }

        public AStructure()
        {
            Id = ++id;
        }

        public void AjouterAnimal(T animal)
        {
            Animaux.Add(animal);
        }

        public void RetirerAnimal(T animal)
        {
            Animaux.Remove(animal);
        }

    }
}
