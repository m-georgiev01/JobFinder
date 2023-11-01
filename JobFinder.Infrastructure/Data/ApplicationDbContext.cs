using JobFinder.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Seeding the database
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfgiguration());

            builder.ApplyConfiguration(new CandidateConfiguration());
            builder.ApplyConfiguration(new EmployerConfiguration());

            builder.ApplyConfiguration(new JobOfferConfiguration());
            builder.ApplyConfiguration(new JobTypeConfiguration());
            builder.ApplyConfiguration(new JobCategoryConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Candidate> Candidates { get; set; } = null!;
        public DbSet<Employer> Employers { get; set; } = null!;
        public DbSet<JobCategory> JobCategories { get; set; } = null!;
        public DbSet<JobOffer> JobOffers { get; set; } = null!;
        public DbSet<JobType> JobTypes { get; set; } = null!;
    }
}