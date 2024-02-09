using SolidPrinciplesC_Demo.DIP;
using SolidPrinciplesC_Demo.ISP;
using SolidPrinciplesC_Demo.LSP;
using SolidPrinciplesC_Demo.OCP;
using SolidPrinciplesC_Demo.SRP;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Choice of Solid Principle");
        Console.WriteLine("------------Menu------------");
        Console.WriteLine("\n 1: SRP \n 2: OCP \n 3: ISP \n 4: LSP \n 5: DIP");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Before_SRP.BeforeSRP();
                After_SRP.AfterSRP();
                break;
            case 2:
                Employee employee = new Employee(1, "Krina", "Permanent");
                Employee employee2 = new Employee(2, "Darji", "Permanent");
                Employee2 employee3 = new PermanentEmployee(1, "Krina");
                Employee2 employee4 = new TemporaryEmployee(2, "Darji");
                Console.WriteLine($"Employee name: {employee3.Name} and Bonus: {employee3.CalculateBonus(100000)}");
                Console.WriteLine($"Employee name: {employee4.Name} and Bonus: {employee4.CalculateBonus(15000)}");
                break;
            case 3:
                IMotorizedVehicle car = new Car1();
                IMotorizedVehicle motorcycle = new Motorcycle1();
                IVehicle1 bicycle = new Bicycle1();

                // Perform vehicle operations
                car.Start();
                car.Accelerate();
                car.Brake();
                car.Stop();
                car.Refuel();

                Console.WriteLine();

                motorcycle.Start();
                motorcycle.Accelerate();
                motorcycle.Brake();
                motorcycle.Stop();
                motorcycle.Refuel();

                Console.WriteLine();

                bicycle.Start();
                bicycle.Brake();
                bicycle.Stop();

                break;
            case 4:
                Rectangle rectangle = new Square(); // This breaks LSP
                rectangle.Width = 5;
                rectangle.Height = 10;

                Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");

                Rectangle1 rectangle1 = new Rectangle1();
                rectangle.Width = 5;
                rectangle.Height = 10;

                Console.WriteLine($"Area of the rectangle: {rectangle1.CalculateArea()}");

                Square1 square = new Square1();
                square.SideLength = 5;

                Console.WriteLine($"Area of the square: {square.CalculateArea()}");

                Console.ReadLine();
                break;
            case 5:
                //before dip
                Notifier notifier = new Notifier();
                notifier.SendNotification();
                Console.ReadLine();

                INotificationService emailService = new EmailService1();
                Notifier1 notifier1 = new Notifier1(emailService);
                notifier1.SendNotification();
                Console.ReadLine();
                break;
        }
        Console.ReadLine();
    }
}