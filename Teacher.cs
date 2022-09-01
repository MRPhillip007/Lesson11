using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw
{
    internal class Teacher
    {
        public string Name { get; }
        public bool IsAdmin { get; }
        public string TeachSubject { get; }
        public Teacher(string name, string teachSubject)
        {
            Name = name;
            IsAdmin = true;
            TeachSubject = teachSubject;
        }
    }
}
