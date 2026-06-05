namespace SmartHome.ApplianceClasses;

public class CoffeeMachine : Appliance, ISchedulable
{
    public int CupsPerBrew { get; set; }
    public DateTime NextRun { get; set; }

    public CoffeeMachine (string brand, string room, int cups) : base(brand, room)
    {
        CupsPerBrew = cups;
    }

    public override string GetInfo()
    {
        return $"{Brand} coffee machine in {Room}";
    }

    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} coffee machine starts a brewing.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} coffee machine stops brewing.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 0.3;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} coffee machine is scheduled at {time.ToString()}.");
    }
}