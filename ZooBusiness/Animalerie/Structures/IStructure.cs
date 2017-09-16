using System.Collections.Generic;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Animaux;
using ZooBusiness.Animalerie.Prix;

namespace ZooBusiness.StructuresZoo.Models
{
    public enum TypeEnvironnement { TerreBattue, Herbe, Foret, Eau, Branchages }
    public enum TypeFermeture { Grillage, Barrière, Cage, Verre }

    public enum EtatStructure { Delabre, Endommage, Bien, Parfait }

    public interface IStructure : IPriceable
    {
        TypeEnvironnement Environnement { get; }

        TypeFermeture Fermeture { get; }

        EtatStructure Etat { get; }

        void Reparer();

        void Casser();

        void AjouterAnimal(AAnimal animal);

        void RetirerAnimal(AAnimal animal);

        IEnumerable<AAnimal> Animaux {get; }

    }
}