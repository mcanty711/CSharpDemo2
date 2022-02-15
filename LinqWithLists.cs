using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLists
{
    class Program
    {
        //Collection of query operators: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Add universities
            universities.Add(new University { Id = 1, Name = "Michigan State" });
            universities.Add(new University { Id = 2, Name = "Michigan" });

            //Add students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 18, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Paul", Gender = "male", Age = 20, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leah", Gender = "female", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Brian", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 19, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female students: ");

            foreach (Student student2 in femaleStudents)
            {
                student2.Print();
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} " +
                "and age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
