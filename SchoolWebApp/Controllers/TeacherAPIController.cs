using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebApp.Models;

namespace SchoolWebApp.Controllers
{
    /// <summary>
    /// API Controller to handle Teacher-related requests.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherAPIController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public TeacherAPIController(SchoolDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET: api/TeacherAPI
        /// Returns a list of all teachers.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            return await _context.Teachers.ToListAsync();
        }

        /// <summary>
        /// GET: api/TeacherAPI/{id}
        /// Returns a teacher by their ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return NotFound(new { message = $"No teacher found with ID {id}" });
            }

            return teacher;
        }
    }
}
