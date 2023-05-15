using School.BusinessModel;

namespace School.BusinessLogic.Interfaces
{
    public interface IStudentBusinessLogic
    {
        //string Test();
        List<Student> GetAllStudents();
    }
}