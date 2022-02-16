using System.ComponentModel.DataAnnotations;

namespace Catalog.Models
{
    public class Course
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Course name must begin with a capital letter and can only contain letters"), Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public int TeacherId { get; set; }

        public Teacher? Teacher { get; set; }
    }
}
