using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class MultipleInheritance
    {
    }


    public class ProductionPlantMultiple
    {
        public string PlantName { get; set; }
        public string Location { get; set; }

        public void ShowPlantInfo()
        {
            Console.WriteLine($"Plant: {PlantName}, Location: {Location}");
        }
    }

    public class ProductionLineMultiple : ProductionPlantMultiple
    {
        public string LineName { get; set; }
        public int MachineCount { get; set; }

        public void ShowLineInfo()
        {
            Console.WriteLine($"Line: {LineName}, Machines: {MachineCount}");
        }
    }

    public class ShiftManager : ProductionLineMultiple
    {
        public string ManagerName { get; set; }
        public string Shift { get; set; }

        public void ShowManagerInfo()
        {
            Console.WriteLine($"Manager: {ManagerName}, Shift: {Shift}");
        }
    }


}
