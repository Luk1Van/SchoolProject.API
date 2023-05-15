using Microsoft.Extensions.Configuration;
using School.DataModel;
using School.Services.Interfaces;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        private readonly IConfiguration _config;
        private readonly string _connstring;

        public StudentService(IConfiguration configuration)
        {
            _config = configuration;
            _connstring = _config.GetConnectionString("SchoolConnection");
        }

        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> students = new List<Student>()
            {
                new Student() {Id = 1, FirstName = "Ivan" , LastName = "L"},
                new Student() {Id = 2, FirstName = "Mark" , LastName = "O"}
            };

            return students;
        }
    }
}