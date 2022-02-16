using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Models
{
    public class Student
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Student name must begin with a capital letter and can only contain letters"), Required, StringLength(50, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Student name must begin with a capital letter and can only contain letters"), Required, StringLength(50, MinimumLength = 3)]
        public string? LastName { get; set; }

        [Display(Name = "RegNumber")]
        [Required, Precision(4, 0)]
        public int? RegistrationNumber { get; set; }

        [NotMapped]
        public double? FinalGrade { get; set; }

        [Display(Name = "Grades")]
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}