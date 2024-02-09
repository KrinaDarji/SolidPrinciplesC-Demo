namespace SolidPrinciplesC_Demo.ISP;

// Interface for basic vehicle operations
public interface IVehicle1
{
    void Start();
    void Stop();
    void Brake();
}

// Interface for motorized vehicles that can move
public interface IMotorizedVehicle : IVehicle
{
    void Accelerate();
   
    void Refuel();
}

// Car class implementing IMotorizedVehicle
public class Car1 : IMotorizedVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }

    public void Accelerate()
    {
        Console.WriteLine("Car accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking");
    }

    public void Refuel()
    {
        Console.WriteLine("Car refueled");
    }
}

// Motorcycle class implementing IMotorizedVehicle
public class Motorcycle1 : IMotorizedVehicle
{
    public void Start()
    {
        Console.WriteLine("Motorcycle started");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle stopped");
    }

    public void Accelerate()
    {
        Console.WriteLine("Motorcycle accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Motorcycle braking");
    }

    public void Refuel()
    {
        Console.WriteLine("Motorcycle refueled");
    }
}
public class Bicycle1 : IVehicle1
{
    public void Start()
    {
        Console.WriteLine("Bicycle started");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped");
    }

    public void Brake()
    {
        Console.WriteLine("Bicycle braking");
    }
}
