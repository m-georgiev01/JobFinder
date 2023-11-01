using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class JobOfferConfiguration : IEntityTypeConfiguration<JobOffer>
    {
        public void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            builder
                .Property(o => o.IsActive)
                .HasDefaultValue(true);

            builder.HasData(CreateJobOffers());
        }

        private List<JobOffer> CreateJobOffers()
        {
            var offers = new List<JobOffer>();

            var offer = new JobOffer()
            {
                Id = 1,
                Title = "Analytical Banking Consultant",
                Content = "<p><strong>Description:</strong></p>\r\n\r\n<p>As an on-staff Consultant with a core focus on data analysis for client operational reviews and analysis of business issues, you will have the opportunity to work on client projects side by side with experienced project team members who have direct industry experience.</p>\r\n\r\n<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n\t<li>Gather and analyze data. Document your findings and make recommendations based upon your analysis.</li>\r\n\t<li>Present your findings through reporting and/or presentations.</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n\t<li>3-5 years of experience working in a banking or financial service industry</li>\r\n\t<li>1-2 Years of data analysis experience</li>\r\n\t<li>Superior Excel skills</li>\r\n\t<li>Excellent verbal and written communication skills</li>\r\n</ul>",
                Salary = 1700m,
                JobTypeId = 2,
                JobCategoryId = 3,
                CreatorId = 1
            };
            offers.Add(offer);

            offer = new JobOffer()
            {
                Id = 2,
                Title = "Java Backend Developer",
                Content = "<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n\t<li>Design, develop and unit test solutions of any size or complexity</li>\r\n\t<li>Produce clean and high-quality code</li>\r\n\t<li>Diagnose defects and provide effective solutions</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n\t<li>A bachelor&#39;s degree and 3+ years of professional experience in Java / Kotlin</li>\r\n\t<li>Profile focused on backend development</li>\r\n\t<li>Experience in container-orchestration platforms such as Kubernetes / Openshift for large scale deployment of micro services is considered as an advantage</li>\r\n\t<li>Excellent verbal and written communication skills</li>\r\n\t<li>Advanced English</li>\r\n</ul>",
                JobTypeId = 2,
                JobCategoryId = 4,
                CreatorId = 1
            };
            offers.Add(offer);

            offer = new JobOffer()
            {
                Id = 3,
                Title = "Telephone Banking Consultant",
                Content = "<p><strong>Description:</strong></p>\r\n\r\n<p>Provides customers excellent telephone service to assure the retention and growth of clients&rsquo; portfolio ensuring that customers receive the best service possible.</p>\r\n\r\n<p>Duration: 8 weeks</p>\r\n\r\n<p><strong>Job Duties and Responsibilities:</strong></p>\r\n\r\n<ul>\r\n\t<li>Analyzes client needs of service and claims, evaluates the different alternatives to satisfy them, and makes decisions to resolve them immediately</li>\r\n\t<li>Promotes cross sales of financial products and services</li>\r\n\t<li>Provide information regarding products and services, such as loans, credit cards, balance inquires, and other</li>\r\n</ul>\r\n\r\n<p><strong>Qualifications:</strong></p>\r\n\r\n<ul>\r\n\t<li>Excellent customer service skills, including telephone skills and telephone etiquette</li>\r\n\t<li>Detail oriented with analytical skills</li>\r\n\t<li>Excellent oral and written communication skills in English and Spanish</li>\r\n</ul>",
                JobTypeId = 1,
                JobCategoryId = 3,
                CreatorId = 1
            };
            offers.Add(offer);

            return offers;
        }
    }
}
