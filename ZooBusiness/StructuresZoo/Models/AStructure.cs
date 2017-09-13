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

        public static List<AStructure<T>> Structures { get; private set; } = new List<AStructure<T>>();

        public int Id { get; private set; }
        public TypeEnvironnement Environnement { get; protected set; }

        public TypeFermeture Fermeture { get; protected set; }

        public EtatStructure Etat { get; protected set; } = EtatStructure.Parfait;

        public List<T> Animaux { get; protected set; } = new List<T>();

        public AStructure()
        {
            Id = ++id;
        }

    }
}
