namespace SmartHome.ApplianceClasses;

public interface ISchedulable
{
    DateTime NextRun { get; set;} 
    void Schedule(DateTime time);
}