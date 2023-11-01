using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(new Employer()
            {
                Id = 1,
                UserId = "02618b16-3bfe-49ee-951e-00e47a895bd6"
            });
        }
    }
}
