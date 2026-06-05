namespace SmartHome.ApplianceClasses;

public class SmartLamp : Appliance
{
    public int Brightness { get; set; }

    public SmartLamp (string brand, string room, int brightness) : base(brand, room)
    {
        Brightness = brightness;
    }

    public override string GetInfo()
    {
        return $"{Brand} smart lamp in {Room}";
    }

    public new void TurnOn()
    {
        Console.WriteLine($"{Brand} smart lamp is turned on.");
    }

}