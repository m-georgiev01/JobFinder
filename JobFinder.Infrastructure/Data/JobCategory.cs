using System.ComponentModel.DataAnnotations;

namespace JobFinder.Infrastructure.Data
{
    public class JobCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
