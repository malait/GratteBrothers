using PetManagement.Data;
using PetManagement.DataAccess.Interface;

namespace PetManagement.DataAccess.Implementation
{
    public class PetOwnerCRUD : IPetOwnerCRUD
    {
        public List<PetOwner> GetAllPetOwners()
        {
            using PetsDBContext dbContext = new PetsDBContext();
            var petAndOwners = dbContext.PetOwners.ToList();

            return petAndOwners;
        }

        public void SavePetOwnerRecord(PetOwner petAndOwner)
        {
            using (PetsDBContext dBContext = new PetsDBContext())
            {
                dBContext.PetOwners.Add(petAndOwner);
                dBContext.SaveChanges();
            }
        }

        public void UpdatePetName(int petOwnerId, string newName)
        {
            using (PetsDBContext dBContext = new PetsDBContext())
            {
                var data = dBContext.PetOwners.Single(x => x.PetOwnerId == petOwnerId);
                data.PetName = newName;

                dBContext.SaveChanges();
            }
        }
    }
}
