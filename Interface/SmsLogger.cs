namespace Interface;

public class SmsLogger : ILogger
{
    public void WriteLog()
    {
       Console.WriteLine("Sms Olarak Log Yazar.");
    }
}