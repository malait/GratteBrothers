using PetManagement.Data;
using PetManagement.DataAccess.Interface;

namespace PetManagement.DataAccess.Implementation
{
    public class SpeciesCRUD : ISpeciesCRUD
    {
        private PetsDBContext _dbContext;
        public SpeciesCRUD(PetsDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Species> GetSpeciesList()
        {
            var species = _dbContext.Species.ToList();

            return species;
        }
    }
}
