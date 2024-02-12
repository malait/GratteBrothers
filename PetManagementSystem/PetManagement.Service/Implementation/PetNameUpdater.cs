using PetManagement.DataAccess.Interface;
using PetManagement.Service.Interface;

namespace PetManagement.Service.Implementation
{
    public class PetNameUpdater : IPetNameUpdater
    {
        private IPetOwnerCRUD _petOwnerCRUD { get; set; }
        public PetNameUpdater(IPetOwnerCRUD petOwnerCRUD)
        {
            _petOwnerCRUD = petOwnerCRUD;
        }

        public void UpdateName(int petOwnerId, string name)
        {
            _petOwnerCRUD.UpdatePetName(petOwnerId, name);
        }
    }
}
