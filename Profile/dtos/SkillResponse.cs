using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profile.dtos
{
    public class SkillResponse
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Proficiency { get; set; }
    }
}
