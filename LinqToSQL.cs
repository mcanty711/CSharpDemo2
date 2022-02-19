using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            String connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.ConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfTonya();
            //GetLectureFromTonya();
            //GetAllStudentsFromMSU();
            //GetAllUniversitiesWithFemales();
            //LecturesAtMSU();
            //UpdateTonya();
            DeleteJeff();


        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University msu = new University();
            msu.Name = "Michigan State University";
            dataContext.Universities.InsertOnSubmit(msu);

            University um = new University();
            um.Name = "University of Michigan";
            dataContext.Universities.InsertOnSubmit(um);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {

            University msu = dataContext.Universities.First(un => un.Name.Equals("Michigan State University"));
            University um = dataContext.Universities.First(un => un.Name.Equals("University of Michigan"));
            //University osu = dataContext.Universities.First(un => un.Name.Equals("The Ohio State University"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carl", Gender = "Male", UniversityId = msu.Id });
            students.Add(new Student { Name = "Tonya", Gender = "Female", University = msu });
            students.Add(new Student { Name = "Sara", Gender = "Female", University = um });
            students.Add(new Student { Name = "Jeff", Gender = "Male", University = um });
            //students.Add(new Student { Name = "Donald", Gender = "Male", University = um });

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;


        }

        public void InsertLectures()
        {
            //create lectures
            Lecture cem = new Lecture();
            cem.Name = "Chemistry";
            dataContext.Lectures.InsertOnSubmit(cem); //must drag the Lecture table from Server Explorer to the LinqToSqlDataClasses.dbml file

            //another way to create lectures:
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });

            //add the lectures to the table:
            dataContext.SubmitChanges();

            //update the main data grid
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations() //this method creates the associate table for LectureId and StudentId
        {
            //create students
            Student Carl = dataContext.Students.First(st => st.Name.Equals("Carl"));
            Student Tonya = dataContext.Students.First(st => st.Name.Equals("Tonya"));
            Student Sara = dataContext.Students.First(st => st.Name.Equals("Sara"));
            Student Jeff = dataContext.Students.First(st => st.Name.Equals("Jeff"));

            Lecture Chemistry = dataContext.Lectures.First(lc => lc.Name.Equals("Chemistry"));
            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));

            //create StudentLectures
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carl, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tonya, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Sara, Lecture = Chemistry });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jeff, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jeff, Lecture = Chemistry });

            //another way to add it
            StudentLecture slTonya = new StudentLecture();
            slTonya.Student = Tonya;
            slTonya.LectureId = Chemistry.Id;
            dataContext.StudentLectures.InsertOnSubmit(slTonya);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        //method to get a university of a specific student
        public void GetUniversityOfTonya()
        {
            Student Tonya = dataContext.Students.First(st => st.Name.Equals("Tonya"));
            
            University TonyasUniversity = Tonya.University;

            List<University> universities = new List<University>();
            universities.Add(TonyasUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        //method to get lectures of a specific student using query
        public void GetLectureFromTonya()
        {
            Student Tonya = dataContext.Students.First(st => st.Name.Equals("Tonya")); //Tonya object

            var tonyasLectures = from sl in Tonya.StudentLectures select sl.Lecture; //query

            MainDataGrid.ItemsSource = tonyasLectures;    
        }

        //method to search for data
        public void GetAllStudentsFromMSU()
        {
            //collection of IEnumerables

            var StudentsFromMSU = from student in dataContext.Students
                                  where student.University.Name == "Michigan State University"
                                  select student;

            MainDataGrid.ItemsSource = StudentsFromMSU;
        }
        // search method using join tables with C# code rather than SQL
        public void GetAllUniversitiesWithFemales()
        {
            var femaleUniversities = from student in dataContext.Students
                                     join university in dataContext.Universities
                                     on student.University equals university
                                     where student.Gender == "Female"
                                     select university;

            MainDataGrid.ItemsSource = femaleUniversities; 
        }

        // method to search for lectures at MSU
        public void LecturesAtMSU()
        {
            var lecturesAtMSU = from sl in dataContext.StudentLectures
                                join student in dataContext.Students
                                on sl.StudentId equals student.Id
                                where student.University.Name == "Michigan State University"
                                select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesAtMSU;
        }

        //method to update data
        public void UpdateTonya()
        {
            Student Tonya = dataContext.Students.FirstOrDefault(st => st.Name == "Tonya");
            
            Tonya.Name = "LaTonya";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        //method to delete data
        public void DeleteJeff()
        {
            Student Jeff = dataContext.Students.FirstOrDefault(st => st.Name == "Jeff");
            dataContext.Students.DeleteOnSubmit(Jeff);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
