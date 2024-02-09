using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesC_Demo.DIP;

// High-level module
public class Notifier
{
    public void SendNotification()
    {
        EmailService emailService = new EmailService();
        emailService.SendEmail();
    }
}

// Low-level module
public class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Sending email...");
    }
}
