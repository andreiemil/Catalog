#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalog.Data;
using Catalog.Models;

namespace Catalog.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Catalog.Data.CatalogContext _context;

        public IndexModel(Catalog.Data.CatalogContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get; set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student
                .Include(g => g.Grades)
                .ThenInclude(g => g.Course)
                .ToListAsync();

            foreach (var student in Student)
            {
                if (student.Grades.Count == 0)
                    continue;
                double totalGrade = 0;
                foreach (var grade in student.Grades)
                {
                    totalGrade = totalGrade + grade.ExamGrade;

                }
                student.FinalGrade = Math.Round(totalGrade / student.Grades.Count, 2);
            }
        }
    }
}
