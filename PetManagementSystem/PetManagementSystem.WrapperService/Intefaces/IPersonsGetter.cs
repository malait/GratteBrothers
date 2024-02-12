using PetManagement.Shared.Models;

namespace PetManagemenSystem.WrapperService.Interfaces
{
    public interface IPersonsGetter
    {
        Task<IEnumerable<Person>> GetAllPersons();
    }
}
