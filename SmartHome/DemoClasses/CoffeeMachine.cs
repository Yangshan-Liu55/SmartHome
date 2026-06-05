namespace SmartHome.DemoClasses;

public class CoffeeMachine
{
    public string Brand { get; set; }
    public int CupsPerBrew { get; set; }

    public CoffeeMachine (string brand, int cups)
    {
        Brand = brand;
        CupsPerBrew = cups;
    }

    public void StartBrewing()
    {
        Console.WriteLine($"{Brand} Coffee Machine starts brewing.");
    }

    public void StopBrewing()
    {
        Console.WriteLine($"{Brand} Coffee Machine stops brewing.");
    }

    public void PrintBrewingEnergy()
    {
        Console.WriteLine($"{Brand} Coffee Machine uses 0.3 kWh per 30 min.");
    }
}