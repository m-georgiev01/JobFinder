using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    internal class UserRoleConfgiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(SeedData());
        }

        private List<IdentityUserRole<string>> SeedData()
        {
            var data = new List<IdentityUserRole<string>>();

            var adminEntry = new IdentityUserRole<string>()
            {
                UserId = "da08baf8-39be-45bd-9def-7ff7ba58309d",
                RoleId = "148e3a33-ff37-4df0-a66f-d26416e5c981"
            };
            data.Add(adminEntry);

            var employerEntry = new IdentityUserRole<string>()
            {
                UserId = "02618b16-3bfe-49ee-951e-00e47a895bd6",
                RoleId = "081218dd-1be7-45e9-a153-eb73758c9f56"
            };
            data.Add(employerEntry);

            var candidateEntry = new IdentityUserRole<string>()
            {
                UserId = "8dc1ad43-1bbf-4034-bd43-733b4697502f",
                RoleId = "68dc4906-58cf-4d2b-9683-bf11ea7d4afa"
            };
            data.Add(candidateEntry);

            return data;
        }
    }
}
