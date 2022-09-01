using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw
{
    internal class ClassRoom
    {
        public string ClassName { get; }
        public Teacher Admin { get; }
        public Dictionary<int, Student>? Students { get; }

        public ClassRoom(List<Student> students, string className, Teacher teacher)
        {
            Students = students.ToDictionary(keySelector: id => id.StudentId, elementSelector: student => student);
            ClassName = className;
            Admin = teacher;
        }

        public void ShowSdutents()
        {
            foreach (KeyValuePair<int, Student> student in Students)
            {
                Console.WriteLine($"\t\t ID: {student.Key}:\n \t\t Name: {student.Value.Name + " " + student.Value.Surname}");
            }
        }
    }
}