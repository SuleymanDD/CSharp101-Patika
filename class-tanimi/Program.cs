namespace class_tanimi;
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
		Calisan calisan1 = new Calisan();
		calisan1.Ad = "Yahya";
		calisan1.Soyad = "Çirpicioğlu";
		calisan1.No = 123456;
		calisan1.Departman = "Finans";
		calisan1.CalisanBilgileri();

		Console.WriteLine("*****Çalişan 2******");
		Calisan calisan2 = new Calisan();
		calisan1.Ad = "Kapta";
		calisan1.Soyad = "Zuni";
		calisan1.No = 782351;
		calisan1.Departman = "Satici";
		calisan1.CalisanBilgileri();
    }
    class Calisan
	{
		public string Ad;
		public string Soyad;
		public int No;
		public string Departman;
		public void CalisanBilgileri()
		{
			Console.WriteLine("Çalişanin Adi: {0}", Ad);
			Console.WriteLine("Çalişanin Soyadi: {0}", Soyad);
			Console.WriteLine("Çalişanin Numarasi: {0}", No);
			Console.WriteLine("Çalişanin Departmani: {0}", Departman);
		}
    }
}


