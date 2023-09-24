namespace ToDo_Uygulamasi;
class Program
{
    static void Main(string[] args)
    {
        Board board=new Board();
        MyMethod.StartMenu(board);
    }
}
static class MyMethod
{
    static void Menu(){
        Console.WriteLine("Lutfen Yapmak Istediginiz Islemi Seciniz");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Tasimak");
        Console.WriteLine("(5) Kart Guncellemek");
    }
    public static void StartMenu(Board board){
        Menu();
        string s_Input=Console.ReadLine();

        switch (s_Input)
        {
            case "1":
                board.BoardListele();
                break;
            case "2":
                board.KartEkle();
                break;
            case "3":
                board.KartSil();
                break;
            case "4":
                board.KartTasi();
                break;
            case "5":
                board.KartGuncelle();
                break;
            default:
                Console.WriteLine("Hatali Tuslama Yaptiniz");
                StartMenu(board);
                break;
        }
    }
}
