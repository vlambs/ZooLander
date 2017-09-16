using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Animaux;

namespace ZooBusiness.StructuresZoo.Models
{


    public abstract class AStructure<T> : IStructure where T : AAnimal
    {
        private static int id = 0;

        public int Id { get; private set; }

        public List<T> Animaux { get; protected set; } = new List<T>();

        public TypeEnvironnement Environnement { get; protected set; }

        public TypeFermeture Fermeture { get; protected set; }

        public EtatStructure Etat { get; protected set; } = EtatStructure.Parfait;

        public int Prix { get; protected set; }

        IEnumerable<AAnimal> IStructure.Animaux => Animaux;

        public AStructure()
        {
            Id = ++id;
        }

        public void Reparer()
        {
            if (Etat != EtatStructure.Parfait)
            {
                Etat++;
            }
           
        }

        public void Casser()
        {
            if (Etat != EtatStructure.Delabre)
            {
                Etat--;
            }
        }

        public void AjouterAnimal(AAnimal animal)
        {
            Animaux.Add((T)animal);
        }

        public void RetirerAnimal(AAnimal animal)
        {
            Animaux.Remove((T)animal);
        }
    }
}
