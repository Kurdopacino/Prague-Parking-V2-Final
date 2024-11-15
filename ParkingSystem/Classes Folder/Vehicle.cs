using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle
{
    public string LicensePlate { get; set; }
    public abstract double Size { get; } // Abstrakt egenskap

    protected Vehicle(string licensePlate)
    {
        LicensePlate = licensePlate;
    }
}

public class Car : Vehicle
{
    public override double Size => 1.0; // Bilens storlek
    public Car(string licensePlate) : base(licensePlate) { }
}

public class Motorcycle : Vehicle
{
    public override double Size => 0.5; // Motorcykelns storlek
    public Motorcycle(string licensePlate) : base(licensePlate) { }
}

public class Helicopter : Vehicle
{
    public override double Size => 5.0; // Helikopterns storlek
    public Helicopter(string licensePlate) : base(licensePlate) { }
}

public class Bus : Vehicle
{
    public override double Size => 2.0; // Bussens storlek
    public Bus(string licensePlate) : base(licensePlate) { }
}

    

