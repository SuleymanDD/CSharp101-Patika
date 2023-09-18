namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
      /*tohumluBitki.Beslenme();
        tohumluBitki.Solunum();
        tohumluBitki.Bosaltim();
        tohumluBitki.FotosentezYapmak();*/
        tohumluBitki.TohumlaCogalma();

        Console.WriteLine("*********************************");

        Kuslar marti = new Kuslar();
      /*marti.Solunum();
        marti.Beslenme();
        marti.Bosaltim();
        marti.Adaptasyon();*/
        marti.Ucmak();
    }
}