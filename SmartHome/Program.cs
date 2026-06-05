using System;
using System.Text;
using System.Collections.Generic;
//using SmartHome.DemoClasses; // Del 1
using SmartHome.ApplianceClasses; // Del 5

class Program
{
    static void Main()
    {
        /* #region Del 1 + Del 2
        // Skapa minst fyra objekt:
        // Washer, Refrigerator, Oven och RobotVacuum.
        // Lägg till dem i listan devices.
        List<object> devices = new List<object>();
        devices.Add(new Washer("LG", 5));
        devices.Add(new Refrigerator("Samsung", 18));
        devices.Add(new Oven("Electrolux", 250));
        devices.Add(new RobotVacuum("Xiaomi", 5));
        // Del 2
        devices.Add(new CoffeeMachine("OBH Nordica", 4));

        Console.WriteLine("--------------- Del 1 + Del 2 --------------");
        RunMorningRoutine(devices);
        Console.WriteLine();
        ReportAllEnergy(devices);
        Console.WriteLine();
        #endregion */

        /* #region Del 5: Lägg till Washer, Refrigerator, Oven, RobotVacuum och CoffeeMachine.
        List<Appliance> devices = new List<Appliance>();
        devices.Add(new Washer("LG", "laundry room", 5));
        devices.Add(new Refrigerator("Samsung", "kitchen", 18));
        devices.Add(new Oven("Electrolux", "kitchen", 250));
        devices.Add(new RobotVacuum("Xiaomi", "living room", 5));
        devices.Add(new CoffeeMachine("OBH Nordica", "kitchen", 4));

        Console.WriteLine("\n--------------- Del 5 --------------");
        RunDailyRoutine(devices);
        Console.WriteLine();
        #endregion */

        #region Del 6 Lägg till minst fem olika apparater.
        SmartHomeController controller = new SmartHomeController();
        controller.AddDevice(new Washer("LG", "laundry room", 5));
        controller.AddDevice(new Refrigerator("Samsung", "kitchen", 18));
        controller.AddDevice(new Oven("Electrolux", "kitchen", 250));
        controller.AddDevice(new RobotVacuum("Xiaomi", "living room", 5));
        controller.AddDevice(new CoffeeMachine("OBH Nordica", "kitchen", 4));
        // Del 7 Lägg till en nyskapad apparat.
        controller.AddDevice(new Dishwasher("Siemens", "kitchen", 70));
        // Del 15 Lägg till AirConditioner
        controller.AddDevice(new AirConditioner("Midea", "bedroom", 18));

        Console.WriteLine("\n--------------- Del 6 + Del 7 --------------");
        controller.PrintStatusReport();
        Console.WriteLine();
        controller.TurnOnAll();
        Console.WriteLine();
        double totalEnergy = controller.GetTotalDailyEnergyUsage();
        Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");
        Console.WriteLine();
        controller.TurnOffAll();
        Console.WriteLine();
        #endregion

        #region Del 9
        Console.WriteLine("\n--------------- Del 9 --------------");
        controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));
        Console.WriteLine();
        #endregion

        #region Del 11 - Labb med new
        SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);
        Appliance lamp2 = lamp1;

        Console.WriteLine("\n--------------- Del 11 --------------");
        lamp1.TurnOn();
        lamp2.TurnOn();
        #endregion

        #region Del 13
        Console.WriteLine("\n--------------- Del 13 --------------");
        List<ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
        foreach (ISchedulable schedulable in schedulableDevices)
        {
            // Skriv ut NextRun eller schemalägg apparaten.
            if (schedulable is Appliance appliance)
            {
                int timeDiff = DateTime.Compare(DateTime.Now, schedulable.NextRun);
                if (timeDiff < 0)
                {
                    Console.WriteLine($"{appliance.GetInfo()} will run at {schedulable.NextRun.ToString()}");
                }
                else if (timeDiff > 0)
                {
                    Console.WriteLine($"{appliance.GetInfo()} is finished running.");
                }
                else
                {
                    Console.WriteLine($"{appliance.GetInfo()} is running.");
                }

            }
        }
        #endregion

        #region Del 14
        Console.WriteLine("\n--------------- Del 14 --------------");
        Appliance foundDevice = controller.FindDeviceByBrand("LG");
        if (foundDevice != null)
        {
            foundDevice.TurnOn();

            if (foundDevice is ISchedulable schedulable)
            {
                schedulable.Schedule(DateTime.Now.AddHours(6));
            }
        }
        #endregion

    }

    /*     // Del 1 + Del 2
        static void RunMorningRoutine(List<object> devices)
        {
            foreach (object device in devices)
            {
                // 1. Kontrollera vilken typ device är.
                // 2. Casta till rätt typ.
                // 3. Anropa rätt startmetod.
                // 4. Anropa rätt stoppmetod.
                if (device.GetType().Equals(typeof(Washer)))
                {
                    Washer washer = (Washer)device;
                    washer.StartWash();
                    washer.StopWash();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.StartCooling();
                    refrigerator.StopCooling();
                }
                else if (device is Oven oven)
                {
                    oven.StartHeating();
                    oven.StopHeating();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.StartCleaning();
                    robotVacuum.StopCleaning();
                }
                else if (device is CoffeeMachine coffeeMachine)
                {
                    coffeeMachine.StartBrewing();
                    coffeeMachine.StopBrewing();
                }
            }
        }

        // Del 1 + Del 2
        static void ReportAllEnergy(List<object> devices)
        {
            foreach (object device in devices)
            {
                // 1. Kontrollera vilken typ device är.
                // 2. Casta till rätt typ.
                // 3. Anropa rätt energimetod.
                if (device.GetType().Equals(typeof(Washer)))
                {
                    Washer washer = (Washer)device;
                    washer.PrintWashEnergy();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.PrintCoolingEnergy();
                }
                else if (device is Oven oven)
                {
                    oven.PrintHeatingEnergy();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.PrintCleaningEnergy();
                }
                else if (device is CoffeeMachine coffeeMachine)
                {
                    coffeeMachine.PrintBrewingEnergy();
                }
            }
        }
     */

    // Del 5
    static void RunDailyRoutine(List<Appliance> devices)
    {
        foreach (Appliance appliance in devices)
        {
            // Skriv ut info.
            // Starta apparaten.
            // Skriv ut energiförbrukning.
            // Stäng av apparaten.
            Console.WriteLine(appliance.GetInfo());
            appliance.TurnOn();
            Console.WriteLine($"{appliance.GetInfo()} uses {appliance.GetDailyEnergyUsage()} kWh per day.");
            appliance.TurnOff();
        }
    }

}


/* Svar
--------- Svar till reflektionsfrågor efter Del 1 -----------
1. Att kontrollera vilken typ varje objekt har kan förhindrar programkrascher.

2. Du lägger till en ny klass, en till if/else-sats i behintliga metoder för CoffeeMachine. 
Då blir kod dålig i läsbarheten, prestandan och underhällbarheten.

3. Metoder RunMorningRoutine() och ReportAllEnergy() måste ändras när ny klass CoffeeMachine läggs.

4. List<object> har objekt i olika Type. De objekten har egna annorlunda metoder att anropa.

5. Då systemet saknar repport för apparattypen som du glömt att lägga till metoden ReportAllEnergy().


--------- Svar till frågor efter Del 2 -----------
När jag lade till CoffeeMachine behövde jag ändra 2 ställen i befintliga koden 
för ny klass CoffeeMachine: Metoder RunMorningRoutine() och ReportAllEnergy()


--------- Svar till frågor efter Del 5 -----------
1. Nyckelordet virtual är grunden för runtime-polymorfism, 
vilket gör att det kan åsidosättas(overridden) i en härledd(derived) klass.
Denna device i typen Appliance har Turn.On() method därför kan den anropas.

2. Metoder overridden i derived klass RobotVacuum körs.
Virtual säkerställer att om en härledd klass overrides en metod, 
kommer C#-runtime att köra den overriden versionen.

3. Jämfört med List<object>, man behöver inte kontrollera vilken typ varje objekt har. 
Man behöver inte ändra befintlig kod när skapa en ny apparat klass.
Polymorfism förbättrar läsbarheten, prestandan och underhällbarheten.


------------ Svar till frågor efter Del 9 ------------
1. Någon typ Appliance variabel såsom Oven har inte inplementera interface ISchedulable,
därför kan den inte anropa Schedule(). Den object(såsom Oven) har inte metoden Schedule().

2. Efter att casta objekt till ISchedulable,
så vet vi att objekt har inplementeras interface ISchedulable.

3. Att RobotVaccum är både en Appliance och ISchedulable, 
betyder att RobotVaccum, som har ärvt Appliance och implememterat ISchedulable, 
kan castas till Appliance eller ISchedulable, och anropa properties och metoder i dem.

4. Inte ligga Schedule() direkt i Appliance,
för att inte alla apparater kan schemaläggas. 
Det blir fel logisk om Appliance har property/method som några apparater aldrig anvander.

5. Skillnader melan arv och interface 
Arv:
- Dela kod och skapa en hierarki(basklass, derived class).
Basklass kan ha default value/implementation i properties/metoder.
- En klass kan ärva bara en enda basklass.

Interface: 
- Skapa ett kontrakt(tomt i interface sent kan göra i derived class).
- En klass kan implementera flera interface.
- Kan ej ha instansvariabler, bara properties, metoder och events.
- Allt är public som standard, och man kan inte ange något annat.

Svar till compiling error i ScheduleAllDevicesWrong(DateTime time), utan att casta interface:
Misslyckades att kompliera detta för att 
inte alla derived klass implementera interfacet ISchedulable som har metoden Schedule().


------------ Svar till frågor efter Del 10 ------------
Test A: Ta bort virtual.
The compiler gave faild errors for 6 derived classes, e.g.:
'Oven.TurnOn()': cannot override inherited member 'Appliance.TurnOn()' because it is not marked virtual, abstract, or override

Test B: Ta bort override
The compiler gave 1 warning for class Oven:
'Oven.TurnOn()' hides inherited member 'Appliance.TurnOn()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.

Vad föreslår C# att du ska använda?
- C# runs Appliance.TurnOn() rather than Oven.TurnOn().
Resultat är: Electrolux is turned on. Men förväntat resultat är: Electrolux oven starts heating.


------------ Svar till frågor efter Del 11 - Labb med new ------------
1. Utskriften är inte samma i compiler:
IKEA smart lamp is turned on. // lamp1.TurnOn();
IKEA is turned on. // lamp2.TurnOn();

2. Variabeln(SmartLamp lamp1) anropas SmartLamp.TurnOn()

3. Variabeln(Appliance lamp2) anropas Appliance.TurnOn()

4. Det är farligt och förvirrande därför att
- new gömmer basklassens metoden(virtual), vilket sker ingen polymorfi.
- Det sker inget komplieringsfel, varken varning.
- Det är dåligt i underhällbarheten.
Till exampel, om man kodade new MetodName i en sub-klass, 
senare en annan utvecklare kodar misstag samma MetodName i form virtual i basklass. 
Då gömms metoden i basklassen vilket är i motsats till förväntad logik.


------------ Svar till frågor efter Del 12 - Labb med sealed ------------
1. Kompilatorn gav compiling error: 
'PizzaOven.TurnOn()': cannot override inherited member 'Oven.TurnOn()' because it is sealed

2. Sealed klass förhindrar derive:a(härledas) klass.
Sealed override property/metod förhindrar derive:a(härledas) den property/metod i sina underklasser. 
Då får PizzaOven inte override:a (sealed override void) TurnOn() i Oven.

3. Det är rimligt att använda sealed override när man vill tillåta derive:a klass,
men stoppa underklasser att använda en virtual metod.

4. PizzaOven kan inte override:a Oven.TurnOn() (sealed override ), 
men den kan skapa en ny metod såsom Bake(), och base.TurnOn() anropar bas metod, 
och fortfarande göra någonting annat, såsom: public void Bake(int temp). 
Ja, PizzaOven kan override:a annan metod som inte ha sealed keyword.


------------ Svar till frågor efter Del 13 ------------
En klass kan ärva bara en enda basklass och samtidigt implementera flera interfaces.
Därför att List<ISchedulable> kan har olika derived klasser(som ärver från Appliance).

*/