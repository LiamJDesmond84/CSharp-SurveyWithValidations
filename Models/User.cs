using System.ComponentModel.DataAnnotations;

namespace CSharp_SurveyWithValidations.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        public string Comment { get; set; }
    }
}
