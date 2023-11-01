using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace JobFinder.Infrastructure.Data
{
    public class JobOffer
    {
        public JobOffer()
        {
            Candidates = new List<Candidate>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Column(TypeName = nameof(SqlDbType.Money))]
        public decimal? Salary { get; set; }

        public bool? IsActive { get; set; }


        [Required]
        public int JobTypeId { get; set; }

        [ForeignKey(nameof(JobTypeId))]
        public JobType JobType { get; set; }


        [Required]
        public int JobCategoryId { get; set; }

        [ForeignKey(nameof(JobCategoryId))]
        public JobCategory JobCategory { get; set; }


        [Required]
        public int CreatorId { get; set; }

        [ForeignKey(nameof(CreatorId))]
        public Employer Creator { get; set; } = null!;


        public ICollection<Candidate> Candidates { get; set; }
    }
}
