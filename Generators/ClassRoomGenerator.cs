using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw.Generators
{
    internal class ClassRoomGenerator
    {
        public List<ClassRoom> ClassRooms { get { return CreateClass(_amountOfCLasses); } }
        private int _amountOfStudents;
        private int _amountOfCLasses;
        public ClassRoomGenerator(int amountOfStudents, int amountOfCLasses)
        {
            _amountOfStudents = amountOfStudents;
            _amountOfCLasses = amountOfCLasses;
        }
        private List<Student> GetStudents()
        {
            StudentGenerator generator = new StudentGenerator(_amountOfStudents);
            return generator.Students;
        }
        private Teacher GetTeacher()
        {
            return TeacherGenerator.Teacher;
        }
        private List<ClassRoom> CreateClass(int classes)
        {
            List<ClassRoom> classesList = new List<ClassRoom>();
            for (int i = 0; i < classes; i++)
            {
                classesList.Add(new ClassRoom(GetStudents(), GetTeacher().TeachSubject, GetTeacher()));
            }
            return classesList;
        }
    }
}
