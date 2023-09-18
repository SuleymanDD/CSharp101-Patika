namespace Interface;

public class FileLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Dosyaya Log Yazar");
    }
}