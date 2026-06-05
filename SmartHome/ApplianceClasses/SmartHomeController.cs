namespace SmartHome.ApplianceClasses;

public class SmartHomeController
{
    private List<Appliance> _devices = new List<Appliance>();
    public void AddDevice(Appliance device)
    {
        // Lägg till device i listan.
        _devices.Add(device);
    }
    public void TurnOnAll()
    {
        // Loopa igenom alla devices och starta dem.
        // Du får inte använda if/switch på specifika klasser.
        foreach (Appliance appliance in _devices)
        {
            appliance.TurnOn();
        }
    }
    public void TurnOffAll()
    {
        // Loopa igenom alla devices och stäng av dem.
        foreach (Appliance appliance in _devices)
        {
            appliance.TurnOff();
        }
    }
    public void PrintStatusReport()
    {
        // Loopa igenom alla devices.
        // Skriv ut GetInfo() och om apparaten är på eller av.
        foreach (Appliance appliance in _devices)
        {
            string status = appliance.IsOn ? "on " : "off";
            Console.WriteLine($"{appliance.GetInfo()} is {status}.");
        }
    }
    public double GetTotalDailyEnergyUsage()
    {
        // Räkna ihop GetDailyEnergyUsage() för alla devices. 
        // Returnera totalsumman.
        double total = 0;
        foreach (Appliance appliance in _devices)
        {
            total += appliance.GetDailyEnergyUsage();
        }
        return total;
    }

    // Del 6
    public void InitAppliances()
    {
        _devices.Add(new Washer("LG", "laundry room", 5));
        _devices.Add(new Refrigerator("Samsung", "kitchen", 18));
        _devices.Add(new Oven("Electrolux", "kitchen", 250));
        _devices.Add(new RobotVacuum("Xiaomi", "living room", 5));
        _devices.Add(new CoffeeMachine("OBH Nordica", "kitchen", 4));
        // Del 7 Lägg till en nyskapad apparat.
        _devices.Add(new Dishwasher("Siemens", "kitchen", 70));
        // Del 15 Lägg till AirConditioner
        _devices.Add(new AirConditioner("Midea", "bedroom", 18));
    }

    // Del 9
    /* public void ScheduleAllDevicesWrong(DateTime time)
    {
        foreach (Appliance device in _devices)
        {
            // Misslyckades att kompliera detta för att
            // inte alla derived klass implementera interfacet ISchedulable som har metoden Schedule().
            device.Schedule(time);
        }
    } */

    // Del 9
    public void ScheduleAllSchedulableDevices(DateTime time)
    {
        foreach (Appliance device in _devices)
        {
            // 1. Kontrollera om device implementerar ISchedulable.
            // 2. Casta device till ISchedulable.
            // 3. Anropa Schedule(time).
            if (device is ISchedulable schedulable)
            {
                schedulable.Schedule(time);
            }
        }
    }

    // Del 13
    internal List<ISchedulable> GetSchedulableDevices()
    {
        List<ISchedulable> result = new List<ISchedulable>();
        foreach (Appliance device in _devices)
        {
            // Om device implementerar ISchedulable,
            // lägg till det i result.
            if (device is ISchedulable schedulable)
            {
                result.Add(schedulable);
            }
        }
        return result;
    }

    // Del 14
    public Appliance FindDeviceByBrand(string brand)
    {
        // Returnera första apparaten med rätt brand. 
        // Om ingen finns kan du returnera null,
        // eller kasta ett eget felmeddelande.
        foreach (Appliance device in _devices)
        {
            if (device.Brand == brand)
            {
                return device;
            }
        }
        Console.WriteLine($"No {brand} appliance found.");
        return null;
    }

}