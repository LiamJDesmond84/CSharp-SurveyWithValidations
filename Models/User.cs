using System.ComponentModel.DataAnnotations;

namespace CSharp_SurveyWithValidations.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        [MaxLength(50)]
        public string? Comment { get; set; }
    }
}
