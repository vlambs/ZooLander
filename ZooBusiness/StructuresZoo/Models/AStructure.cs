using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;

namespace ZooBusiness.StructuresZoo.Models
{


    public abstract class AStructure<T> : IStructure where T : AAnimal<T>
    {
        private static int id = 0;

        public static List<AStructure<T>> Structures { get; private set; } = new List<AStructure<T>>();

        public int Id { get; private set; }


        public List<T> Animaux { get; protected set; } = new List<T>();

        public TypeEnvironnement Environnement { get; protected set; }

        public TypeFermeture Fermeture { get; protected set; }

        public EtatStructure Etat { get; protected set; } = EtatStructure.Parfait;

        public int Prix { get; protected set; }

        public AStructure()
        {
            Id = ++id;
        }

    }
}
