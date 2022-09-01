using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncupsulationHw
{
    static class Schedule
    {
        public static string Shedule { get { return GetShedule(); } }
        private static readonly string[] schedule = new string[]
        {
            "Monday: 8:30Am - PE",
            "Tuesday: 9:00Am - Math",
            "Wednesday: 10:45 - Physics",
            "Thursday: 11:35 - Biology",
            "Friday: 12:25 - Chemistry"
        };

        private static  string GetShedule()
        {
            return String.Join("\n", schedule);
        }

    }
}
