namespace Inheritance;
public class Bitkiler:Canlilar
{
    protected void FotosentezYapmak()
    {
        Console.WriteLine("Bitkiler Fotosentez Yapar.");
    }
    public override void UyaranalaraTepki()
    {
       // base.UyaranalaraTepki();
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }

}

public class TohumluBitkiler:Bitkiler
{   public TohumluBitkiler()
    {
        base.FotosentezYapmak();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.UyaranalaraTepki();
    }

    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler:Bitkiler
{   public TohumsuzBitkiler()
    {
        base.FotosentezYapmak();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void SporlaCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}