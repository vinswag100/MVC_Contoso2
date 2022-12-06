namespace MVC_Contoso2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}