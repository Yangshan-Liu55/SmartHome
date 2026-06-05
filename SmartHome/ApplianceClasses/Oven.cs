namespace SmartHome.ApplianceClasses;

public class Oven : Appliance
{
    public int MaxTemperature { get; set; }

    public Oven (string brand, string room, int temp) : base(brand, room)
    {
        MaxTemperature = temp;
    }

    public override string GetInfo()
    {
        return $"{Brand} oven in {Room}";
    }

    public sealed override void TurnOn()
    {
        Console.WriteLine($"{Brand} oven starts heating.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} oven stops heating.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 2.5;
    }
}