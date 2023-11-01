using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.IsActive)
                .HasDefaultValue(true);

            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "8dc1ad43-1bbf-4034-bd43-733b4697502f",
                UserName = "candidate@mail.com",
                NormalizedUserName = "candidate@mail.com",
                Email = "candidate@mail.com",
                NormalizedEmail = "candidate@mail.com",
                FullName = "Martin Georgiev"
            };

            user.PasswordHash = hasher.HashPassword(user, "candidate123");
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "02618b16-3bfe-49ee-951e-00e47a895bd6",
                UserName = "employer@mail.com",
                NormalizedUserName = "employer@mail.com",
                Email = "employer@mail.com",
                NormalizedEmail = "employer@mail.com",
                FullName = "UniCredit Bulbank"
            };

            user.PasswordHash = hasher.HashPassword(user, "employer123");
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "da08baf8-39be-45bd-9def-7ff7ba58309d",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                FullName = "Admin Admin"
            };

            user.PasswordHash = hasher.HashPassword(user, "admin123");
            users.Add(user);

            return users;
        }
    }
}
