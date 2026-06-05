namespace SmartHome.DemoClasses;

public class Oven
{
    public string Brand { get; set; }
    public int MaxTemperature { get; set; }

    public Oven (string brand, int temp)
    {
        Brand = brand;
        MaxTemperature = temp;
    }

    public void StartHeating()
    {
        Console.WriteLine($"{Brand} oven starts heating.");
    }

    public void StopHeating()
    {
        Console.WriteLine($"{Brand} oven stops heating.");
    }

    public void PrintHeatingEnergy()
    {
        Console.WriteLine($"{Brand} oven uses 2.5 kWh per hour.");
    }
}