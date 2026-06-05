namespace SmartHome.ApplianceClasses;

public class Dishwasher : Appliance, ISchedulable
{
    public int Temperature { get; set; }
    public DateTime NextRun { get; set; }

    public Dishwasher (string brand, string room, int temp) : base(brand, room)
    {
        Temperature = temp;
    }

    public override string GetInfo()
    {
        return $"{Brand} dishwasher in {Room}";
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} dishwasher starts washing dishes.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} dishwasher stops washing dishes.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 1;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} dishwasher is scheduled at {time.ToString()}.");
    }
}