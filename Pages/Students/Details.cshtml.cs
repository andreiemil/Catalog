#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Catalog.Models;

namespace Catalog.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Catalog.Data.CatalogContext _context;

        public DetailsModel(Catalog.Data.CatalogContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.
                Include(s => s.Grades)
                .ThenInclude(g => g.Course)
                .FirstOrDefaultAsync(m => m.ID == id);



            if (Student == null)
            {
                return NotFound();
            }

            if (Student.Grades == null || Student.Grades.Count == 0)
            {
                return Page();
            }

            double totalGrade = 0;
            foreach (var grade in Student.Grades)
            {

                totalGrade = totalGrade + grade.ExamGrade;

            }
            Student.FinalGrade = Math.Round(totalGrade / Student.Grades.Count, 2);

            return Page();
        }
    }
}
