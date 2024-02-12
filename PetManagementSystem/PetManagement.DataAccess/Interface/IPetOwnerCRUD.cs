using PetManagement.Data;

namespace PetManagement.DataAccess.Interface
{
    public interface IPetOwnerCRUD
    {
        List<PetOwner> GetAllPetOwners();
        void SavePetOwnerRecord(PetOwner petAndOwner);
        void UpdatePetName(int petOwnerId, string newName);
    }
}
