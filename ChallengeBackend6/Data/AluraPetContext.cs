using ChallengeBackend6.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeBackend6.Data
{
    public class AluraPetContext: DbContext
    {
        public AluraPetContext(DbContextOptions<AluraPetContext> opts)
            : base(opts) 
        {

        }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
