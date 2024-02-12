using PetManagement.Shared.Models;

namespace PetManagemenSystem.WrapperService.Interfaces
{
    public interface IPetOwnerAdder
    {
        void AddNewPetOwner(PetOwner petOwner);
    }
}
