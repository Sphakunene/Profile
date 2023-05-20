using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.dtos
{
    public class PersonRequest
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; } 
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string? ProfessionalSummary { get; set; }
        [Required]
        public string? ProfilePicture { get; set; }
        [Required]
        public string? Password { get; set; }

        public ICollection<SkillRequest> Skills { get; set; }
    }
}
