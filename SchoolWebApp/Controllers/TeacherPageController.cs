using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebApp.Models;

namespace SchoolWebApp.Controllers
{
    /// <summary>
    /// MVC Controller to serve Teacher web pages.
    /// </summary>
    public class TeacherPageController : Controller
    {
        private readonly SchoolDbContext _context;

        public TeacherPageController(SchoolDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays a list of all teachers.
        /// Route: /Teacher/List
        /// </summary>
        public async Task<IActionResult> List()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }

        /// <summary>
        /// Displays details of a single teacher by ID.
        /// Route: /Teacher/Show/{id}
        /// </summary>
        public async Task<IActionResult> Show(int id)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);

            if (teacher == null)
            {
                return NotFound("Teacher not found.");
            }

            return View(teacher);
        }
    }
}
