using School.DataModel;

namespace School.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> Get();
    }
}