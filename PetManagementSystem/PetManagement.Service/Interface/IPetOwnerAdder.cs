using PetManagement.Shared.Models;

namespace PetManagement.Service.Interface
{
    public interface IPetOwnerAdder
    {
        void AddNewPetOwner(PetOwner petOwner);
    }
}
