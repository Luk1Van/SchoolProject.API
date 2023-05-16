namespace School.DataModel
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SignUpDate { get; set; }
        public int DepartmentId { get; set; }
        public int CountrytId { get; set; }

    }
}