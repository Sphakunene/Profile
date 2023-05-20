using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persons.dtos
{
    public class SkillRequest
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Proficiency { get; set; }
    }
}
