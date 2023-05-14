using System.ComponentModel.DataAnnotations;
using WebApplicationMVC.Models.Validators;

namespace WebApplicationMVC.Models
{
    public class Member
    {
        [Required(ErrorMessage = "Podaj Nazwę")]
        [MinLength(2, ErrorMessage = "Za krótka Nazwa")]
        [MaxLength(10, ErrorMessage = "Za długa Nazwa")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Podaj Email")]
        [EmailAddress]
        public string Email { get; set; } = default!;
        [Required]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Podaj poprawny kod!")]
        public string ZipCode { get; set; } = default!;
        //[Range(0,140)]
        [AgeOver(18)]
        public int Age { get; set; }
    }
}
