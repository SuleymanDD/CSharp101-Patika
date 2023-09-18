namespace Inheritance;
public class Canlilar
{
    protected void Beslenme()
    {
        Console.WriteLine("Canlilar beslenir.");
    }
    protected void Solunum()
    {
        Console.WriteLine("Canlilar Solunum yapar.");
    }
    protected void Bosaltim()
    {
        Console.WriteLine("Canlilar bosaltim yapar.");
    }
    public virtual void UyaranalaraTepki()
    {
        Console.WriteLine("Canlılar Uyaranlara Tepki verir.");
    }
}
