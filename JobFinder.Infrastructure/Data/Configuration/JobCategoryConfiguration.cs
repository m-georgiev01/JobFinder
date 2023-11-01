using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class JobCategoryConfiguration : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<JobCategory> CreateCategories()
        {
            var categories = new List<JobCategory>();

            var category = new JobCategory()
            {
                Id = 1,
                Name = "Retail"
            };
            categories.Add(category);

            category = new JobCategory()
            {
                Id = 2,
                Name = "Tourism"
            };
            categories.Add(category);

            category = new JobCategory()
            {
                Id = 3,
                Name = "Banking"
            };
            categories.Add(category);

            category = new JobCategory()
            {
                Id = 4,
                Name = "Development"
            };
            categories.Add(category);

            category = new JobCategory()
            {
                Id = 5,
                Name = "Real estate"
            };
            categories.Add(category);

            return categories;
        }
    }
}
