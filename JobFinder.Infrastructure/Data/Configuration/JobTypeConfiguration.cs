using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class JobTypeConfiguration : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasData(CreateJobTypes());
        }

        private List<JobType> CreateJobTypes()
        {
            var jobTypes = new List<JobType>();

            var jobType = new JobType()
            {
                Id = 1,
                Name = "Part time"
            };
            jobTypes.Add(jobType);

            jobType = new JobType()
            {
                Id = 2,
                Name = "Full time"
            };
            jobTypes.Add(jobType);

            jobType = new JobType()
            {
                Id = 3,
                Name = "Freelance project"
            };
            jobTypes.Add(jobType);

            return jobTypes;
        }
    }
}
