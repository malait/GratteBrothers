using PetManagement.Shared.Models;

namespace PetManagement.Service.Interface
{
    public interface IPersonsGetter
    {
        List<Person> GetAllPersons();
    }
}
