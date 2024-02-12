using PetManagement.Shared.Models;

namespace PetManagemenSystem.WrapperService.Interfaces
{
    public interface IPetOwnerGetter
    {
        Task<IEnumerable<PetOwner>> GetPetOwnerList();
    }
}
