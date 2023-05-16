using Dapper;
using Microsoft.Extensions.Configuration;
using School.DataModel;
using School.Services.Interfaces;
using System.Data.SqlClient;
using System.Reflection.Metadata;

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
            IEnumerable<Student> students = new List<Student>();
            try
            {
                string query = "dbo.GetStudents";
                using(var sqlConn = new SqlConnection(_connstring))
                {
                    students = sqlConn.Query<Student>(query, commandType: System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return students;
        }
    }
}