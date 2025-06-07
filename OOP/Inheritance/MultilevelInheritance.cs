using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class MultilevelInheritance
    {
    }

    public interface ILocatable
    {
        void GetLocation();
    }

    public interface IReportable
    {
        void GenerateReport();
    }

    public class RobotOperator : ILocatable, IReportable
    {
        public void GetLocation()
        {
            Console.WriteLine("Robot is currently in Zone 5.");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Report: Robot completed 120 units today.");
        }
    }

}
