using MVC_Contoso2.Models;

namespace MVC_Contoso2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Zara",LastName="Mason",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="chaya",LastName="Xavier",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Artur",LastName="Ahmed",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gervonta",LastName="Gamona",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Yin",LastName="yang",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Richards",LastName="reed",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="bueno",LastName="Kinder",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nano",LastName="Ovito",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Computing",Credits=3},
                new Course{CourseID=4022,Title="Computing With Web Development",Credits=3},
                new Course{CourseID=4041,Title="Computing With Game Development",Credits=3},
                new Course{CourseID=1045,Title="Game Development",Credits=4},
                new Course{CourseID=3141,Title="Artificial Intelligence",Credits=4},
                new Course{CourseID=2021,Title="Internet Security",Credits=3},
                new Course{CourseID=2042,Title="Computing With Foundation Year",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}