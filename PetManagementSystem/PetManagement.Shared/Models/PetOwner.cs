namespace PetManagement.Shared.Models
{
    public class PetOwner
    {
        public int PetOwnerId { get; set; }
        public Species PetType { get; set; }
        public Person Owner { get; set; }
        public string PetName { get; set;}

    }
}
