namespace SolidPrinciplesC_Demo.ISP;

public interface IVehicle
{
    void Start();
    void Stop();
    void Accelerate();
    void Brake();
    void Refuel();
}

// Car class implementing IVehicle
public class Car : IVehicle
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

// Motorcycle class implementing IVehicle
public class Motorcycle : IVehicle
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

public class Bicycle : IVehicle
{
    public void Accelerate()
    {
        throw new NotImplementedException();
    }

    public void Brake()
    {
        Console.WriteLine("bicycle braking");
    }

    public void Refuel()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        Console.WriteLine("bicycle started");
    }

    public void Stop()
    {
        Console.WriteLine("bicycle stopped");
    }

    
}