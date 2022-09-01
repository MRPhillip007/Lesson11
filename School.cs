using System;
using System.Globalization;
using System.Numerics;
using IncupsulationHw.Generators;


namespace IncupsulationHw
{
    internal class School
    {
        private static readonly string[] _classes = new string[5]
        {
            "Math", "PE", "Chemistry","Biology", "Physics"
        };
        int _students;
        int _classRooms;
        ClassRoomGenerator _roomGenerator;
        public static string[] AvaliableClasses { get { return _classes; } }
        public School(int students, int classes)
        {
            _students = students;
            _classRooms = classes;
            _roomGenerator = new ClassRoomGenerator(_students, _classRooms);
        }
        public void ShowClass()
        {
            for (int i = 0; i < _roomGenerator.ClassRooms.Count; i++)
            {
                Console.WriteLine(String.Format("{0}\nISAdmin: {1}\nTechSybject: {2}\nClass number: {3}\n",
                    _roomGenerator.ClassRooms[i].Admin.Name,
                    _roomGenerator.ClassRooms[i].Admin.IsAdmin,
                    _roomGenerator.ClassRooms[i].Admin.TeachSubject, 
                    i+1));

                _roomGenerator.ClassRooms[i].ShowSdutents();
            }
        }

        public void PrintShedule()
        {
            Console.WriteLine("<===== School Shedule =====>");
            Console.WriteLine(Schedule.Shedule);
            Console.WriteLine();
        }

    }
}
