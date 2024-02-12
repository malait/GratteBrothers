using PetManagement.Data;

namespace PetManagement.DataAccess.Interface
{
    public interface ISpeciesCRUD
    {
        List<Species> GetSpeciesList();
    }
}
