using System;

namespace Origam.Sms
{
    public class FileSystemSmsService : ISmsService
    {
        public void SendSms(string from, string to, string body)
        {
            Console.WriteLine($"Sending sms from {from} to {to}, with text {body}");
        }
    }
}