using System.ComponentModel.DataAnnotations;
namespace Catalog.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Display(Name = "Teacher first name")]
        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Teacher first name must begin with a capital letter and can only contain letters"), Required, StringLength(50, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [Display(Name = "Teacher last name")]
        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Teacher last name must begin with a capital letter and can only contain letters"), Required, StringLength(50, MinimumLength = 3)]
        public string? LastName { get; set; }
    }
}
