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
    public class Zoo
    {
        public List<Visiteur> Visiteurs { get; private set; } = new List<Visiteur>();

        public Stock Stock { get; private set; }

        public Tresorerie Tresorerie { get; private set; }

        public Directeur Directeur { get; }

        public List<IStructure> Structures { get { return Stock.Structures; } }

        public Zoo(Stock stock, Tresorerie tresorerie,Directeur directeur)
        {
            Stock = stock;
            Tresorerie = tresorerie;
            Directeur = directeur;
        }

        #region Structure
        public void ReparerStructure<T>(Entretien entretien,AStructure<T> structure) where T : AAnimal<T>
        {
            entretien.Reparer(structure);
        }

        public AStructure<T> GetStructure<T>(T animal) where T : AAnimal<T>
        {
            var typedStructures = Structures.Where(s => s is AStructure<T>).Select(s => (AStructure<T>)s);
            return typedStructures.Where(s => s.Animaux.Contains(animal)).FirstOrDefault();
        }

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
        #endregion

        #region GestionAnimal


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

        public void Soigner<T>(Soigneur soigneur, T animal, ISoin soin) where T : AAnimal<T>
        {
            if (Stock.Soins.Remove(soin)) { try { soigneur.Soigner(animal, soin); } catch { GetStructure(animal).Casser(); } }
        }

        public void Reproduire<T>(T a1, T a2) where T : AAnimal<T>
        {
            var structure = GetStructure(a1);
            if (!structure.Animaux.Contains(a2))
            {
                throw new ReproductionNotAllowedException();
            }
            structure.Animaux.Add((T)typeof(T).GetMethod("Reproduction").Invoke(null, new object[] { a1, a2 }));
        }


        public void Nourrir<T>(Soigneur soigneur, AAnimal<T> animal, INourriture food)
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
