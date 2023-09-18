namespace Abstract;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Interface ***");
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

        Console.WriteLine("*** Abstract ***");

        NewFocus newFocus = new NewFocus();
        Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
        Console.WriteLine(newFocus.kacTekerlektenOlusur().ToString());
        Console.WriteLine(newFocus.StandartRengiNe().ToString());

        NewCorolla newCorolla = new NewCorolla();
        Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(newCorolla.kacTekerlektenOlusur().ToString());
        Console.WriteLine(newCorolla.StandartRengiNe().ToString());

        NewCivic newCivic = new NewCivic();
        Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
        Console.WriteLine(newCivic.kacTekerlektenOlusur().ToString());
        Console.WriteLine(newCivic.StandartRengiNe().ToString());

    }
}
