using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //We simply apply our Student-Structure to XML.
            string studentsXML =
                    @"<Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21</Age>
                            <Class>Senior</Class>
                            <University>Michigan State</University>
                        </Student>
                        <Student>
                            <Name>Carla</Name>
                            <Age>19</Age>
                            <Class>Sophmore</Class>
                            <University>Michigan State</University>
                        </Student>
                        <Student>
                            <Name>Leah</Name>
                            <Age>20</Age>
                            <Class>Junior</Class>
                            <University>Michigan</University>
                        </Student>
                        <Student>
                            <Name>Michael</Name>
                            <Age>18</Age>
                            <Class>Fressman</Class>
                            <University>Michigan</University>
                        </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student") 
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Class = student.Element("Class").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is a {3}", student.Name, student.Age, student.University, student.Class);

            }

            var sortedStudents = from student in students orderby student.Age select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Students sorted by Age: {0} {1}", student.Name, student.Age);
            }
        }
    }
}
