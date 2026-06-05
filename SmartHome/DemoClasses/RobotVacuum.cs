namespace SmartHome.DemoClasses;

public class RobotVacuum
{
    public string Brand { get; set; }
    public int BatteryLevel { get; set; }

    public RobotVacuum (string brand, int level)
    {
        Brand = brand;
        BatteryLevel = level;
    }

    public void StartCleaning()
    {
        Console.WriteLine($"{Brand} robot vaccum starts cleaning.");
    }

    public void StopCleaning()
    {
        Console.WriteLine($"{Brand} robot vaccum stops cleaning.");
    }

    public void PrintCleaningEnergy()
    {
        Console.WriteLine($"{Brand} robot vaccum uses 0.4 kWh per cleaning.");
    }
}