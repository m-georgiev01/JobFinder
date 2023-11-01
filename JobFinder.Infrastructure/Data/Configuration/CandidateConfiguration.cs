using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasData(new Candidate()
            {
                Id = 1,
                UserId = "8dc1ad43-1bbf-4034-bd43-733b4697502f"
            });
        }
    }
}
