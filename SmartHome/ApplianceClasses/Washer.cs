namespace SmartHome.ApplianceClasses;

public class Washer : Appliance, ISchedulable
{
    public int CapacityKg { get; set; }
    public DateTime NextRun { get; set; }

    public Washer (string brand, string room, int cap) : base(brand, room)
    {
        CapacityKg = cap;
    }

    public override string GetInfo()
    {
        return $"{Brand} washer in {Room}";
    }

    public override void TurnOn()
    {
        //base.TurnOn();
        Console.WriteLine($"{Brand} washer starts a washing program.");
    }

    public override void TurnOff()
    {
        //base.TurnOff();
        Console.WriteLine($"{Brand} washer stops washing program.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 1.2;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} washer is scheduled at {time.ToString()}.");
    }
}