using Microsoft.EntityFrameworkCore;

namespace APIdotnet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<APIdotnet.Models.Utilisateur> Utilisauteurs { get; set; }
        public DbSet<APIdotnet.Models.Entreprise> Entreprises { get; set; }
        public DbSet<APIdotnet.Models.Site> Sites { get; set; }
        public DbSet<APIdotnet.Models.Departement> Departements { get; set; }
        public DbSet<APIdotnet.Models.Salarie> Salaries { get; set; }
        public DbSet<APIdotnet.Models.Ville> Villes { get; set; }
        public DbSet<APIdotnet.Models.Newsletter> Newsletters { get; set; }
        public DbSet<APIdotnet.Models.Contact> Contacts { get; set; }



    }
}
