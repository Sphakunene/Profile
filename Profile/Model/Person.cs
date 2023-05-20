using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.Model
{
    public class Person
    {
        [Key]
        [Required]
        public int Id { get; set; }
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
        
        [ForeignKey("SkillId")]
        public ICollection<Skill> Skills { get; set; }
    }
}
