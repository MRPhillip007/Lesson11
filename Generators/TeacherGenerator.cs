using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncupsulationHw;
namespace IncupsulationHw.Generators
{
    internal class TeacherGenerator: Generator
    {
        public static Teacher Teacher { get { return CreateTeacher(); } }

        private static readonly string[] _teachers = new string[]
        {
            "Елена Гальвицкая", "Наталия Гутарук", "Наталья Кидалова", "Оксана Мироняк", "Наталья Пашковская", "Сергей Петрович"
        };

        private static string GetSubject()
        {
            int randomIndex = Random.Next(0, School.AvaliableClasses.Length);
            return School.AvaliableClasses[randomIndex];
        }
        private static Teacher CreateTeacher()
        {
            return new Teacher(_teachers[Random.Next(0, _teachers.Length)], GetSubject());
        }
    }
}
