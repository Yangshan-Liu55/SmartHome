namespace SmartHome.DemoClasses;

public class Refrigerator
{
    public string Brand { get; set; }
    public int Temperature { get; set; }

    public Refrigerator (string brand, int temp)
    {
        Brand = brand;
        Temperature = temp;
    }

    public void StartCooling()
    {
        Console.WriteLine($"{Brand} refrigerator starts cooling.");
    }

    public void StopCooling()
    {
        Console.WriteLine($"{Brand} refrigerator stops cooling.");
    }

    public void PrintCoolingEnergy()
    {
        Console.WriteLine($"{Brand} refrigerator uses 3.6 kWh per day.");
    }
}