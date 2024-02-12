using PetManagement.DataAccess.Interface;
using PetManagement.Service.Interface;
using PetManagement.Shared.Models;

namespace PetManagement.Service.Implementation
{
    public class PersonsGetter : IPersonsGetter
    {
        private IPersonCRUD _personCRUD { get; set; } = null!;

        public PersonsGetter(IPersonCRUD personCRUD)
        {
            _personCRUD = personCRUD;
        }

        public List<Person> GetAllPersons()
        {
            List<Person> persons = _personCRUD.GetPersonDetails().Select(x =>
                                        new Person()
                                        {
                                            PersonId = x.PersonId,
                                            PersonName = x.PersonName,
                                        }).ToList();

            return persons;
        }
    }
}
