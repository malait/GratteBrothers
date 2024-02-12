namespace PetManagement.Data
{
    public class PetOwner
    {
        public int PetOwnerId { get; set; }
        public Species PetType { get; set; } = null!;
        public Person Owner { get; set; } = null!;
        public string PetName { get; set; } = null!;

    }
}
