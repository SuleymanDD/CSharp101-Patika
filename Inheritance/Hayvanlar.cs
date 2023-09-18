namespace Inheritance;

public class Hayvanlar:Canlilar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon kurabilir");
    }

}

public class Sürüngenler:Hayvanlar
{
    public Sürüngenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }

    public void SurunerekHareketEtmek()
    {
        Console.WriteLine("Sürüngeler sürünerek hareket ederler.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar");
    }
}