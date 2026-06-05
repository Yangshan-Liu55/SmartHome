namespace SmartHome.DemoClasses;

public class Washer
{
    public string Brand { get; set; }
    public int CapacityKg { get; set; }

    public Washer (string brand, int cap)
    {
        Brand = brand;
        CapacityKg = cap;
    }

    public void StartWash()
    {
        Console.WriteLine($"{Brand} washer starts washing.");
    }

    public void StopWash()
    {
        Console.WriteLine($"{Brand} washer stops washing.");
    }

    public void PrintWashEnergy()
    {
        Console.WriteLine($"{Brand} washer uses 1.2 kWh per wash.");
    }
}