using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Animaux;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;
using ZooBusiness.OrganisationZoo.Models;
using ZooBusiness.OrganisationZoo.Models.ResourcesZoo;
using ZooBusiness.StructuresZoo.Models;

namespace ZooBusiness.OrganisationZoo.Controllers
{
    public class Zoo
    {
        public List<Visiteur> Visiteurs { get; private set; } = new List<Visiteur>();

        public Stock Stock { get; private set; }

        public Tresorerie Tresorerie { get; private set; }

        public Directeur Directeur { get; }

        public List<IStructure> Structures { get { return Stock.Structures; } }

        public List<AAnimal> Animaux { get { return Stock.Animaux; } }

        public Zoo(int baseSomme)
        {
            Directeur = new Directeur();
            Stock = new Stock(new Magasinier());
            Tresorerie = new Tresorerie(new Tresorier(), baseSomme);
        }

        public Zoo(Stock stock, Tresorerie tresorerie,Directeur directeur)
        {
            Stock = stock;
            Tresorerie = tresorerie;
            Directeur = directeur;
        }

        #region Structure
        public void ReparerStructure<T>(Entretien entretien,AStructure<T> structure) where T : AAnimal
        {
            entretien.Reparer(structure);
        }

        public void CommanderStructure<T>(AStructure<T> structure) where T : AAnimal
        {
            try
            {
                Tresorerie.Depenser(structure);
                Stock.Structures.Add(structure);
            }
            catch
            {

            }
        }
        #endregion

        #region GestionAnimal


        public void CommanderAnimal(AAnimal animal, IStructure structure)
        {
            try
            {
                structure.AjouterAnimal(animal);
                Stock.Animaux.Add(animal);
                Tresorerie.Depenser(animal);        
            }
            catch
            {
         
            }
        }

        public void CommanderAnimal(AAnimal animal) 
        {
            try
            {
                Tresorerie.Depenser(animal);
                Stock.Animaux.Add(animal);
            }
            catch
            {

            }
        }

        public void Soigner(Soigneur soigneur, AAnimal animal, ISoin soin) 
        {
            if (Stock.Soins.Remove(soin)) {soigneur.Soigner(animal, soin); }
        }

        public void Reproduire<T>(T a1, T a2,AStructure<T> structure) where T : AAnimal
        {
            T animal = AAnimal.Reproduction<T>(a1, a2);
            Stock.Animaux.Add(animal);
            structure.AjouterAnimal(animal);
        }


        public void Nourrir(Soigneur soigneur, AAnimal animal, INourriture food)
        {
            if (Stock.Nourritures.Remove(food)) {
                    soigneur.Nourrir(animal, food);
                }
        }
        #endregion

        #region Stock & Tresorerie

        public void VendrePlace(Visiteur v)
        {
            Tresorerie.ComptabiliserEntree(v.AcheterTicket());
            Visiteurs.Add(v);
        }

        public void CommanderSoin(ISoin soin)
        {
            try
            {
                Tresorerie.Depenser(soin);
                Stock.Soins.Add(soin);
            }
            catch
            {

            }
        }

        public void CommanderNourriture(INourriture food)
        {
            try
            {
                Tresorerie.Depenser(food);
                Stock.Nourritures.Add(food);
            }
            catch
            {

            }
        }
        #endregion
    }
}
