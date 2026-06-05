namespace SmartHome.ApplianceClasses;

public class PizzaOven : Oven
{
    public PizzaOven(string brand, string room, int maxTemperature) : base(brand, room, maxTemperature)
    {
    }

    public override string GetInfo()
    {
        return $"{Brand} pizza oven in {Room}";
    }

    /* // public sealed override void TurnOn() in Oven, so cannot override here
    public override void TurnOn()
    {
        Console.WriteLine("Pizza oven starts at extra high temperature.");
    } */

    public void Bake(int temp)
    {
        MaxTemperature = temp;
        base.TurnOn();
        Console.WriteLine($"{Brand} Pizza oven starts at extra high temperature.");
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