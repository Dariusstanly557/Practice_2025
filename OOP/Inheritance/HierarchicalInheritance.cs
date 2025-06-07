
namespace OOP.Inheritance
{
    public class HierarchicalInheritance
    {
    }

    // ProductionPlant
    //     /      |       \
    //ProductionLine HRManager  QualityManager


    public class ProductionPlantHierarchical
    {
        public string PlantName { get; set; }
        public string Location { get; set; }

        public void ShowPlantInfo()
        {
            Console.WriteLine($"Plant: {PlantName}, Location: {Location}");
        }
    }

    public class ProductionLineHierarchical : ProductionPlantHierarchical
    {
        public string LineName { get; set; }

        public void ShowLineInfo()
        {
            Console.WriteLine($"Production Line: {LineName}");
        }
    }

    public class HRManager : ProductionPlantHierarchical
    {
        public string ManagerName { get; set; }

        public void ShowHRInfo()
        {
            Console.WriteLine($"HR Manager: {ManagerName}");
        }
    }





}
