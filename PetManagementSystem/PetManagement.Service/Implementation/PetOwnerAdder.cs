using PetManagement.DataAccess.Interface;
using PetManagement.Service.Interface;
using PetManagement.Shared.Models;

namespace PetManagement.Service.Implementation
{
    public class PetOwnerAdder : IPetOwnerAdder
    {
        private IPetOwnerCRUD _petOwnerCRUD { get; set; }
        public PetOwnerAdder(IPetOwnerCRUD petOwnerCRUD)
        {
            _petOwnerCRUD = petOwnerCRUD;
        }

        public void AddNewPetOwner(PetOwner petOwner)
        {
            var petOwnerData = new PetManagement.Data.PetOwner()
            {
                PetName = petOwner.PetName,
                PetType = new PetManagement.Data.Species()
                {
                    SpeciesId = petOwner.PetType.SpeciesId,
                    SpeciesName = petOwner.PetType.SpeciesName,
                },
                Owner = new PetManagement.Data.Person()
                {
                    PersonId = petOwner.Owner.PersonId,
                    PersonName = petOwner.Owner.PersonName,
                }
            };

            _petOwnerCRUD.SavePetOwnerRecord(petOwnerData);
        }
    }
}
