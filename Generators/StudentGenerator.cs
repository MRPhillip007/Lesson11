using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw.Generators
{
    internal class StudentGenerator : Generator
    {
        public List<Student> Students { get { return Create(_numberOsStudents); } }

        private readonly int _numberOsStudents;
        private readonly string[] _names = new string[] {

            "Вася", "Александр", "Роман", "Дима", "Ваня", "Петя", "Максим"
        };

        private readonly string[] _surnames = new string[] {
            "Пупкин", "Ерманченко", "Калосов", "Нагилевич", "Галенко", "Нестрович", "Хлебоедов"
        };

        public StudentGenerator(int studentNumber)
        {
            _numberOsStudents = studentNumber;
        }
        private List<Student> Create(int count)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                students.Add(new Student(_names[Random.Next(0, _names.Length)], _surnames[Random.Next(0, _surnames.Length)]));
            }
            return students;
        }
    }
}
