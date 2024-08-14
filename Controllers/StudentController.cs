using Coreweb_api_token.Interface;
using Coreweb_api_token.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coreweb_api_token.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Istudents _Istudent;

        public StudentController(Istudents Istudent)
        {
            _Istudent = Istudent;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            return await Task.FromResult(_Istudent.GetStudentDetails());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var employees = await Task.FromResult(_Istudent.GetStudentDetailsByid(id));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }

        // POST api/employee
        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {
            _Istudent.AddStudent(student);
            return await Task.FromResult(student);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> Put(int id, Student student)
        {
            if (id != student.Stuid)
            {
                return BadRequest();
            }
            try
            {
                _Istudent.UpdateStudent(student);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckStudent(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(student);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> Delete(int id)
        {
            var stu = _Istudent.DeleteStudent(id);
            return await Task.FromResult(stu);
        }

        private bool CheckStudent(int id)
        {
            return _Istudent.CheckStudent(id);
        }
    }
}
