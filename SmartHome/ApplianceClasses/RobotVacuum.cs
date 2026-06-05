namespace SmartHome.ApplianceClasses;

public class RobotVacuum : Appliance, ISchedulable
{
    public int BatteryLevel { get; set; }
    public DateTime NextRun { get; set; }

    public RobotVacuum (string brand, string room, int level) : base(brand, room)
    {
        BatteryLevel = level;
    }

    public override string GetInfo()
    {
        return $"{Brand} robot vacuum in {Room}";
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} robot vaccum starts cleaning.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} robot vaccum stops cleaning.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 0.4;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} robot vaccum is scheduled at {time.ToString()}.");
    }
}