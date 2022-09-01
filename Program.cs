using IncupsulationHw;
using IncupsulationHw.Generators;

class Program
{
    static void Main()
    {
        School washingtonSchool = new School(5, 4);
        washingtonSchool.PrintShedule();
        washingtonSchool.ShowClass();
    }

}

