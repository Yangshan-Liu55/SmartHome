# Smart Home System

A C# console application for learning **Inheritance (Arv)** and **Polymorphism**.

## Purpose

This project simulates a smart home system with different household appliances. 
It demonstrates Object-Oriented Programming concepts in C# and shows how polymorphism makes applications easier to extend and maintain.

### Topics Covered

* Inheritance
* Base classes and derived classes
* Keyword virtual
* Keyword override
* Keyword new
* Keyword sealed
* Polymorphic collections (`List<Appliance>`)
* Interfaces
* Casting to interfaces
* Benefits of polymorphism and extensible design

## Class Structure

### SmartHomeController

* Using `SmartHomeController` to Centralized data processing. Program.cs handles execution, and the controller processes data.

### Interface

* `ISchedulable` Differ devices if can be scheduled. E.g. Washer can be scheduled, but coffee machine cannot be scheduled.

### Base Class

* `Appliance`

### Derived Classes

Examples include:

* `AirConditioner`
* `CoffeeMachine`
* `Dishwasher`
* `Oven`
* `Refrigerator`
* `RobotVacuum`
* `Washer`

## Main Features

### Appliance Control

* RunDailyRoutine: `TurnOn()`, `TurnOnAll()`, `ScheduleAllSchedulableDevices()`

### Energy Monitoring

* Calculate total daily energy consumption.

### Scheduling

* Schedule supported appliances that implement Interface `IShedulable` to run at a specific date and time.

### Smart Devices

* Through interfaces and polymorphism, make the system good in scalability, readability, performance and maintainability.

## Command

## Run project

cd SmartHome\
dotnet run

## Run unit test project

cd SmartHome.Tests\
dotnet test

## Example Console Output

### Part 6 + Part 7

```text
LG washer in laundry room is off.
Samsung refrigerator in kitchen is off.
Electrolux oven in kitchen is off.
Xiaomi robot vacuum in living room is off.
OBH Nordica coffee machine in kitchen is off.
Siemens dishwasher in kitchen is off.
Midea air conditioner in bedroom is off.

LG washer starts a washing program.
Samsung refrigerator starts cooling.
Electrolux oven starts heating.
Xiaomi robot vacuum starts cleaning.
OBH Nordica coffee machine starts brewing.
Siemens dishwasher starts washing dishes.
Midea air conditioner starts blowing.

Total daily energy usage: 10.5 kWh

LG washer stops washing program.
Samsung refrigerator stops cooling.
Electrolux oven stops heating.
Xiaomi robot vacuum stops cleaning.
OBH Nordica coffee machine stops brewing.
Siemens dishwasher stops washing dishes.
Midea air conditioner stops blowing.
```

### Part 9

```text
LG washer is scheduled at 6/5/2026 2:10:58 PM.
Xiaomi robot vacuum is scheduled at 6/5/2026 2:10:58 PM.
OBH Nordica coffee machine is scheduled at 6/5/2026 2:10:58 PM.
Siemens dishwasher is scheduled at 6/5/2026 2:10:58 PM.
Midea air conditioner is scheduled at 6/5/2026 2:10:58 PM.
```

### Part 11

```text
IKEA smart lamp is turned on.
IKEA is turned on.
```

### Part 13

```text
LG washer in laundry room will run at 6/5/2026 2:10:58 PM
Xiaomi robot vacuum in living room will run at 6/5/2026 2:10:58 PM
OBH Nordica coffee machine in kitchen will run at 6/5/2026 2:10:58 PM
Siemens dishwasher in kitchen will run at 6/5/2026 2:10:58 PM
Midea air conditioner in bedroom will run at 6/5/2026 2:10:58 PM
```

### Part 14

```text
LG washer starts a washing program.
LG washer is scheduled at 6/5/2026 6:10:58 PM.
```

## Why Polymorphism?

Without polymorphism, the program would need separate handling for every appliance type.

By storing all devices in a collection of `Appliance` objects, the system can:

* Treat all appliances uniformly
* Execute common operations with less code
* Add new appliance types without modifying existing logic
* Follow the Open/Closed Principle


## Technologies

* C#
* .NET
* Object-Oriented Programming (OOP)
* XUnit test

## Learning Outcome

After completing this exercise, we should understand how inheritance, interfaces, and polymorphism work together to create flexible and maintainable software designs.
