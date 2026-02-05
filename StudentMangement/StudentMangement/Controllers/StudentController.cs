using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using  StudentMangement.Service;
using StudentMangement.Model;
namespace StudentMangement.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            this._service = service;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var student = _service.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            if (student == null)
                return BadRequest("Student data is null");

            _service.Add(student);
            return Ok("Student created successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student student)
        {
            var existingStudent = _service.GetById(id);
            if (existingStudent == null)
                return NotFound("Student not found");

            _service.Update(id, student);
            return Ok("Student updated successfully");
        }

        // DELETE: api/students/1
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _service.GetById(id);
            if (student == null)
                return NotFound("Student not found");

            _service.Delete(id);
            return Ok("Student deleted successfully");

        }

    }
}