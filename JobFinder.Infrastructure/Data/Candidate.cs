using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinder.Infrastructure.Data
{
    public class Candidate
    {
        public Candidate()
        {
            JobOffers = new List<JobOffer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
