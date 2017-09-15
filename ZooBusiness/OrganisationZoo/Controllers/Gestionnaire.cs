using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBusiness.Animalerie;
using ZooBusiness.Animalerie.Nourriture;
using ZooBusiness.Animalerie.Soins;
using ZooBusiness.OrganisationZoo.Models;
using ZooBusiness.OrganisationZoo.Models.ResourcesZoo;
using ZooBusiness.StructuresZoo.Models;

namespace ZooBusiness.OrganisationZoo.Controllers
{
    public class Gestionnaire
    {
        public List<Visiteur> Visiteurs { get; private set; }

        public Stock Stock { get; private set; }

        public Tresorerie Tresorerie { get; private set; }

        public Directeur Directeur { get; }

        public List<IStructure> Structures { get { return Stock.Structures; } }

        #region GestionAnimal

        public void CommanderStructure<T>(AStructure<T> structure) where T : AAnimal<T>
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
        public void CommanderAnimal<T>(T animal, AStructure<T> structure) where T : AAnimal<T>
        {
            try
            {
                Tresorerie.Depenser(animal);
                structure.Animaux.Add(animal);
            }
            catch
            {

            }
        }

        public void Soigner<T>(Soigneur soigneur, AAnimal<T> animal, ISoin soin)
        {
            if (Stock.Soins.Remove(soin)) { soigneur.Soigner(animal, soin); }
        }


        public void Nourrir<T>(Soigneur soigneur, AAnimal<T> animal, INourriture food)
        {
            if (Stock.Nourritures.Remove(food)) { soigneur.Nourrir(animal, food); }
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
