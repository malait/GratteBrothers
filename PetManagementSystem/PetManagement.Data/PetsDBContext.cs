using Microsoft.EntityFrameworkCore;

namespace PetManagement.Data
{
    public class PetsDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Species> Species { get; set; } = null!;
        public DbSet<PetOwner> PetOwners { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=PetManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
