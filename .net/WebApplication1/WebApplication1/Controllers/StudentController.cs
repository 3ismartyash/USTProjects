using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _Students = new List<Student>
        {
            new Student { Id = 1, Name = "yashuuu", sex = "male", dept = "AI" },
            new Student { Id = 2, Name = "Manuuu", sex = "male", dept = "IT"},
            new Student { Id = 3, Name = "vidyaaa", sex = "female", dept = "TI"},
            // Add more students
        };

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return _Students;
        }
        // GET: api/students/2
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _Students.FirstOrDefault(p => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

            [HttpPost]
            public ActionResult<Student> PostStudent(Student student)
            {
                _Students.Add(student);
                return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
            }
            // PUT: api/students/5
            [HttpPut("{id}")]
            public IActionResult PutStudent(int id, Student student)
            {
                if (id != student.Id)
                {
                    return BadRequest();
                }
                var existingStudent = _Students.FirstOrDefault(p => p.Id == id);
                if (existingStudent == null)
                {
                    return NotFound();
                }
                existingStudent.Name = student.Name;
                existingStudent.sex = student.sex;
                existingStudent.dept = student.dept;
                // In a real application, here you would update the students in the database
                return NoContent();
            }
            // DELETE: api/students/5
            [HttpDelete("{id}")]

            public IActionResult DeleteProduct(int id)
            {
                var student = _Students.FirstOrDefault(p => p.Id == id);
                if (student == null)
                {
                    return NotFound();  
                }
                _Students.Remove(student);
                // In a real application, here you would delete the product from the database
                return NoContent();
            }
    }
}
