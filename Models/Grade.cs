using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }

        [Required, Precision(3, 2)]
        [Range(1, 10)]
        public double ExamGrade { get; set; }

        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
