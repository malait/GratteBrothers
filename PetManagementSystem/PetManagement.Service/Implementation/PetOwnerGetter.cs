using PetManagement.DataAccess.Interface;
using PetManagement.Service.Interface;
using PetManagement.Shared.Models;

namespace PetManagement.Service.Implementation
{
    public class PetOwnerGetter : IPetOwnerGetter
    {
        private IPetOwnerCRUD _petOwnerCRUD {  get; set; }

        public PetOwnerGetter(IPetOwnerCRUD petOwnerCRUD)
        {
            _petOwnerCRUD = petOwnerCRUD;
        }

        public List<PetOwner> GetPetOwnerList()
        {
            var petOwnerList = _petOwnerCRUD.GetAllPetOwners().Select(x =>
                                        new PetOwner()
                                        {
                                            PetOwnerId = x.PetOwnerId,
                                            PetName = x.PetName,
                                            PetType = new Species()
                                            {
                                                SpeciesId = x.PetType.SpeciesId,
                                                SpeciesName = x.PetType.SpeciesName
                                            },
                                            Owner = new Person()
                                            {
                                                PersonId = x.Owner.PersonId,
                                                PersonName = x.Owner.PersonName,
                                            }
                                        }).ToList();
            return petOwnerList;
        }
    }
}
