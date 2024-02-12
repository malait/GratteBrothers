using PetManagement.Shared.Models;

namespace PetManagemenSystem.WrapperService.Interfaces
{
    public interface ISpeciesGetter
    {
        Task<IEnumerable<Species>> GetAllSpecies();
    }
}
