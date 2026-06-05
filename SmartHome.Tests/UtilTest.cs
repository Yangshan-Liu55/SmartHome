using System.Collections.Generic;
using SmartHome.ApplianceClasses;

namespace SmartHome.Tests;

public class UtilTest
{
    private SmartHomeController _controller = new SmartHomeController();

    public static readonly Dictionary<Type, double> ApplianceDailyEnergyUsage = new Dictionary<Type, double>()
    {
        {typeof(Washer), 1.2},
        {typeof(Refrigerator), 3.6},
        {typeof(Oven), 2.5},
        {typeof(RobotVacuum), 0.4},
        {typeof(CoffeeMachine), 0.3},
        {typeof(Dishwasher), 1},
        {typeof(AirConditioner), 1.5}
    };

    public static IEnumerable<object[]> ApplianceTestData => new[]
    {
        new object[] { new Washer("LG", "laundry room", 5) },
        new object[] { new Refrigerator("Samsung", "kitchen", 18) },
        new object[] { new Oven("Electrolux", "kitchen", 250) },
        new object[] { new RobotVacuum("Xiaomi", "living room", 5) },
        new object[] { new CoffeeMachine("OBH Nordica", "kitchen", 4) },
        new object[] { new Dishwasher("Siemens", "kitchen", 70) },
        new object[] { new AirConditioner("Midea", "bedroom", 18) }
    };

    [Fact]
    public void GetTotalDailyEnergyUsage_ShouldBeCorrectResult()
    {
        //Arrange
        double expected = 1.2 + 3.6 + 2.5 + 0.4 + 0.3 + 1 + 1.5;
        _controller.InitAppliances();

        //Act
        double actual = _controller.GetTotalDailyEnergyUsage();

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(ApplianceTestData))]
    public void GetDailyEnergyUsage_ShouldBeCorrectResult(Appliance device)
    {
        //Arrange
        double expected = ApplianceDailyEnergyUsage[device.GetType()];

        //Act
        double actual = device.GetDailyEnergyUsage();

        //Assert
        Assert.Equal(expected, actual);
    }

}
