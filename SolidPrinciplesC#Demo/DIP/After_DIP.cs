namespace SolidPrinciplesC_Demo.DIP;

// Abstraction
public interface INotificationService
{
    void SendNotification();
}

// High-level module
public class Notifier1
{
    private INotificationService _notificationService;

    public Notifier1(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void SendNotification()
    {
        _notificationService.SendNotification();
    }
}

// Low-level module
public class EmailService1 : INotificationService
{
    public void SendNotification()
    {
        Console.WriteLine("Sending email...");
    }
}
