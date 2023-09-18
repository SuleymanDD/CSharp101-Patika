namespace Interface_ornek;
class Program
{
    static void Main(string[] args)
    {
        Focus focus = new Focus();
        Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
        Console.WriteLine(focus.StandartRengiNe().ToString());

        Corolla corolla = new Corolla();
        Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(corolla.kacTekerlektenOlusur().ToString());
        Console.WriteLine(corolla.StandartRengiNe().ToString());

        Civic civic = new Civic();
        Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
        Console.WriteLine(civic.StandartRengiNe().ToString());
    }
}
