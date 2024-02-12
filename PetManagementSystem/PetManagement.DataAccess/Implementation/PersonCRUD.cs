using PetManagement.Data;
using PetManagement.DataAccess.Interface;

namespace PetManagement.DataAccess.Implementation
{
    public class PersonCRUD : IPersonCRUD
    {
        public List<Person> GetPersonDetails()
        {
            using PetsDBContext context = new PetsDBContext();
            var persons = context.Persons.ToList();

            return persons;
        }
    }
}
