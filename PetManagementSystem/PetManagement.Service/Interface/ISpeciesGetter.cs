using PetManagement.Shared.Models;

namespace PetManagement.Service.Interface
{
    public interface ISpeciesGetter
    {
        List<Species> GetAllSpecies();
    }
}
