using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
            NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
            NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

            emailNotificationHandler.Successor = smsNotificationHandler;
            smsNotificationHandler.Successor = voiceNotificationHandler;

            emailNotificationHandler.Handle(receiver);
        }
    }
}
