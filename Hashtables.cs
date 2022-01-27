using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            //retrieve entries from hashtable by first creating a student object
            //then get the student value from your table and access it by an Id
            //typecast it to type Student.

            Student storedStudent1 = (Student)studentsTable[1];

            Console.WriteLine("Studen ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            //retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }
            //or a better way
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student Id: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
        }
    }
    public class Student
    {
        //property call Id
        public int Id { get; set; }
        //property called Name
        public string Name { get; set; }
        //property called GPA
        public float GPA { get; set; }
        //simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}

using System;
using System.Collections;

namespace Hashtables2
{
    class Program 
    {
        static void Main(string[] args)
        {
            // This programs adds the entries from an array to a Hashtable
            Hashtable table = new Hashtable();
            
            Student[] students = new Student[5];
            students[0] = new Student(1, "Charissa", 68);
            students[1] = new Student(2, "Derrick", 32);
            students[2] = new Student(3, "Clifton", 84);
            students[3] = new Student(1, "Marcus", 75);
            students[4] = new Student(5, "Jason", 79);

            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine("Student with ID {0} has been added", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same Id already exists ID: {0}", s.Id); 
                }
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GPA { get; set; }

        //constructor
        public Student(int Id, string Name, int GPA)
        {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
    }
}

