using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP.Inheritance.HybridInheritance;

namespace OOP.Inheritance
{
    public class HybridInheritance
    {

        





    }

    public class ProductionPlantHybrid
    {
        public string PlantName { get; set; }

        public void ShowPlantInfo()
        {
            Console.WriteLine($"Plant Name: {PlantName}");
        }
    }

    public interface IQualityLogger
    {
        void LogDefect(string defect);
    }
    public interface IAnalyzer
    {
        void AnalyzeData();
    }

    public class QualityManager : ProductionPlantHybrid, IQualityLogger, IAnalyzer
    {
        public string ManagerName { get; set; }

        public void LogDefect(string defect)
        {
            Console.WriteLine($"{ManagerName} logged defect: {defect}");
        }

        public void AnalyzeData()
        {
            Console.WriteLine($"{ManagerName} is analyzing production data...");
        }
    }

}
