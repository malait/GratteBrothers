using PetManagement.Shared.Models;

namespace PetManagement.Service.Interface
{
    public interface IPetOwnerGetter
    {
        List<PetOwner> GetPetOwnerList();
    }
}
