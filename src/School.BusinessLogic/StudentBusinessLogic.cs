using AutoMapper;
using School.BusinessLogic.Interfaces;
using School.BusinessModel;
using School.Services.Interfaces;

namespace School.BusinessLogic
{
    public class StudentBusinessLogic : IStudentBusinessLogic
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentBusinessLogic(IStudentService studentService,
                                    IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                IEnumerable<DataModel.Student> studentsDM = _studentService.Get();
                students = _mapper.Map<List<Student>>(studentsDM);
            }
            catch (Exception ex)
            {

                throw;
            }
            return students;
        }
    }
}