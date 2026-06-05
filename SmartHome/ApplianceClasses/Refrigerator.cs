namespace SmartHome.ApplianceClasses;

public class Refrigerator : Appliance
{
    public int Temperature { get; set; }

    public Refrigerator (string brand, string room, int temp) : base(brand, room)
    {
        Temperature = temp;
    }

    public override string GetInfo()
    {
        return $"{Brand} refrigerator in {Room}";
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} refrigerator starts cooling.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} refrigerator stops cooling.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 3.6;
    }
}