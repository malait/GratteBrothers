using PetManagement.Data;

namespace PetManagement.DataAccess.Interface
{
    public interface IPersonCRUD
    {
        List<Person> GetPersonDetails();
        //void SavePerson(Person person);
    }
}
