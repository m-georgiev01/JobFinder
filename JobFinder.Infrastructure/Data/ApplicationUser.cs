using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JobFinder.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(70)]
        public string FullName { get; set; } = null!;

        public bool? IsActive { get; set; } = true;
    }
}
