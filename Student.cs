using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw
{
    internal class Student
    {
        Random random = new Random();
        public string Name { get; }
        public string Surname { get; }
        public int StudentId { get; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            StudentId = random.Next(999999999);
        }
    }
}
