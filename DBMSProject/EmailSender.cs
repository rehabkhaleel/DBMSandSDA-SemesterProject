using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMSProject
{
    public class EmailSender : IUserSignUpObserver
    {
        public void NotifyNewUserSignUp(string username, string email)
        {
            // Logic to send email notification
            string message = $"New user '{username}' signed up with email '{email}'.";
            // SendEmail(email, message);
            Console.WriteLine($"Email sent to {email}: {message}");
        }
    }
}