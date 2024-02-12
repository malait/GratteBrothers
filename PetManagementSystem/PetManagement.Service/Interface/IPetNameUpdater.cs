namespace PetManagement.Service.Interface
{
    public interface IPetNameUpdater
    {
        void UpdateName(int petOwnerId, string name);
    }
}
