using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinder.Infrastructure.Data
{
    public class Employer
    {
        public Employer()
        {
            JobOffers = new List<JobOffer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
