namespace SmartHome.ApplianceClasses;

public class AirConditioner : Appliance, ISchedulable
{
    public int TargetTemperature { get; set; }
    public DateTime NextRun { get; set; }

    public AirConditioner (string brand, string room, int temp) : base(brand, room)
    {
        TargetTemperature = temp;
    }

    public override string GetInfo()
    {
        return $"{Brand} air conditioner in {Room}";
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} air conditioner starts blowing.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} air conditioner stops blowing.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 1.5;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} air conditioner is scheduled at {time.ToString()}.");
    }
}