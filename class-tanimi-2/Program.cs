namespace class_tanimi_2;
class Program
{
    static void Main(string[] args)
    {
        // Söz dizimi
		// class sinifAdi
		//{
		//[Erişim belirleyici] [Veri tipi] OzellikAdi;
		//[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
		//{
		//Metot komutları
		//}
		//}
		//Erişim belirleyiciler
		// * Public
		// * Private
		// * Internal
		// * Protected

		Console.WriteLine("*****Çalişan 1******");
		Calisan calisan1 = new Calisan("Nevzat","Çirpicioğlu",1806538,"IT");
		calisan1.CalisanBilgileri();

		Console.WriteLine("*****Çalişan 2******");
		Calisan calisan2 = new Calisan();
		calisan2.Ad = "Yahya";
		calisan2.Soyad = "Çirpicioğlu";
		calisan2.No = 123456;
		calisan2.Departman = "Finans";
		calisan2.CalisanBilgileri();

		Console.WriteLine("*****Çalişan 3******");
		Calisan calisan3 = new Calisan("Nevzat","Çirpicioğlu");
		calisan3.CalisanBilgileri();

    }
}
class Calisan
{
	public string Ad;
	public string Soyad;
	public int No;
	public string Departman;

    public Calisan() { } //Constructor 1

    public Calisan(string ad, string soyad) // Constructor 2
    {
        this.Ad=ad;
        this.Soyad=soyad;
    } 
	public Calisan(string ad, string soyad, int no, string departman) // Constructor 3
	{
		this.Ad = ad;
		this.Soyad = soyad;
		this.No = no;	
		this.Departman = departman;	
	}
	public void CalisanBilgileri()
	{
		Console.WriteLine("Çalişanin Adi: {0}", Ad);
		Console.WriteLine("Çalişanin Soyadi: {0}", Soyad);
		Console.WriteLine("Çalişanin Numarasi: {0}", No);
		Console.WriteLine("Çalişanin Departmani: {0}", Departman);
	}
}
