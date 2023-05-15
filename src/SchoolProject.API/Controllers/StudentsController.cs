using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.BusinessLogic.Interfaces;
using School.BusinessModel;

namespace SchoolProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentBusinessLogic _studentBusinessLogic;

        public StudentsController(IStudentBusinessLogic studentBusinessLogic)
        {
            _studentBusinessLogic = studentBusinessLogic;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            try
            {
                return _studentBusinessLogic.GetAllStudents();
            }
            catch (Exception ex)
            {

                return Ok();
            }
        }
    }
}
