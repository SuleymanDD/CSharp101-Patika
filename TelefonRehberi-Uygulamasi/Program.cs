namespace TelefonRehberi_Uygulamasi;
class Program
{
    static void Main(string[] args)
    {
        Rehber rehber=new Rehber();
        MyMethod.StartMenu(rehber);
    }
    
}
static class MyMethod
{
    static void Menu(){
        Console.WriteLine("Lutfen Yapmak Istediginiz Islemi Seciniz");
        Console.WriteLine("****************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Kisiyi Silmek");
        Console.WriteLine("(3) Varolan Numarayi Guncellemek");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
    }
    public static void StartMenu(Rehber rehber){
        Menu();

        string seInput=Console.ReadLine();
        switch (seInput)
        {
            case "1":
                rehber.RehberEkle();
                break;
            case "2":
                rehber.KisiSil();
                break;
            case "3":
                rehber.KisiUpdate();
                break;
            case "4":
                rehber.RehberListele();
                break;
            case "5":
                rehber.RehberSearch();
                break;
            default:
                Console.WriteLine("Hatali Tuslama Yaptiniz");
                StartMenu(rehber);
                break;
        }
    }
}
