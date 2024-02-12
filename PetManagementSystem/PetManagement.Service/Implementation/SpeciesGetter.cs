using PetManagement.DataAccess.Interface;
using PetManagement.Service.Interface;
using PetManagement.Shared.Models;

namespace PetManagement.Service.Implementation
{
    public class SpeciesGetter : ISpeciesGetter
    {
        private ISpeciesCRUD _speciesCRUD {  get; set; }
        public SpeciesGetter(ISpeciesCRUD speciesCRUD) 
        {
            _speciesCRUD = speciesCRUD;
        }

        public List<Species> GetAllSpecies()
        {
            var speciesList = _speciesCRUD.GetSpeciesList().Select(x =>
                                    new Species()
                                    {
                                        SpeciesId = x.SpeciesId,
                                        SpeciesName = x.SpeciesName
                                    }).ToList();
            return speciesList;
        }
    }
}
