

using static OOP.Inheritance.SingleInheritance;

namespace OOP.Inheritance
{
    public class SingleInheritance
    {








    }

    public class ProductionPlant
    {
        public string PlantName { get; set; }
        public string Location { get; set; }

        public void ShowPlantInfo()
        {
            Console.WriteLine($"Plant Name: {PlantName}");
            Console.WriteLine($"Location: {Location}");
        }
    }

    public class ProductionLine : ProductionPlant
    {
        public string LineName { get; set; }
        public int WorkersCount { get; set; }

        public void ShowLineInfo()
        {
            Console.WriteLine($"Line Name: {LineName}");
            Console.WriteLine($"Number of Workers: {WorkersCount}");
        }
    }



}

