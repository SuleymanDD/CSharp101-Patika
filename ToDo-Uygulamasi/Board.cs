namespace ToDo_Uygulamasi;

class Board
{
    List<Kart> kartlar=new List<Kart>();
    public Board(){
        kartlar.Add(new Kart("Ates","Yakar",Boyut.XS,1,1));
        kartlar.Add(new Kart("Su","Islatir",Boyut.S,2,1));
        kartlar.Add(new Kart("Toprak","Kuru",Boyut.M,3,1));
    }
    public void BoardListele(){
        Console.WriteLine("ToDo Line");
        Console.WriteLine("************************");
        foreach (var item in kartlar){
            if(item.Line_index.ToString()=="ToDo"){
                YazdirTemplate(item);
                Console.WriteLine();
            }
        }
        Console.WriteLine("\nIn Progress Line");
        Console.WriteLine("************************");
        foreach (var item in kartlar){
            if(item.Line_index.ToString()=="InProgress"){
                YazdirTemplate(item);
                Console.WriteLine();
            }
        }
        Console.WriteLine("\nDone Line");
        Console.WriteLine("************************");
        foreach (var item in kartlar){
            if(item.Line_index.ToString()=="Done"){
                YazdirTemplate(item);
                Console.WriteLine();
            }
        }
    }
    public void KartEkle(){
        string m_title,m_text;
        int m_boyut,m_kisi;
        bool checkNumber;
        do{
            Console.Write("Baslik Giriniz: ");
            m_title=Console.ReadLine();
        }while(!StringControl(m_title));

        do{
            Console.Write("Icerik Giriniz: ");
            m_text=Console.ReadLine();
        }while(!StringControl(m_text));

        do{
            Console.Write("Buyukluk Seciniz => XS(1),S(2),M(3),L(4),XL(5) ");
            checkNumber=int.TryParse(Console.ReadLine(),out m_boyut);
        }while(!BoyutControl(m_boyut,checkNumber));

        do{
            Console.Write("Kisiyi Seciniz => Ahmet(1) Mehmet(2) Ayse(3) ");
            checkNumber=int.TryParse(Console.ReadLine(),out m_kisi);
        }while(!Kisi_LineControl(m_kisi,checkNumber));

        kartlar.Add(new Kart(m_title,m_text,m_boyut,m_kisi,1));
        Console.WriteLine("Kart Eklendi");
        MOTemplate();
    }
    public void KartSil(){
        Console.WriteLine("Oncelikle Silmek Istediginiz Karti Secmeniz Gerekiyor.");
        Console.Write("Lutfen Kart Basligini Yaziniz: ");
        string i_title=Console.ReadLine();
        int tmp=kartlar.Count;

        kartlar.RemoveAll(x => x.Title==i_title);
        if(tmp==kartlar.Count){
            KartSilNotFound();
        }else{
            Console.WriteLine("Kartlar Silindi");
            MOTemplate();
        }
    }
    public void KartTasi(){
        Console.WriteLine("Oncelikle Tasimak Istediginiz Karti Secmeniz Gerekiyor.");
        Console.Write("Lutfen Kart Basligini Yaziniz: ");
        string i_title=Console.ReadLine();

        int sayac=0;
        foreach (var item in kartlar)
        {
            if(item.Title==i_title){
                int m_line;
                bool checkNumber;
                sayac++;
                do{
                    KartTasiTemplate(item);
                    checkNumber=int.TryParse(Console.ReadLine(),out m_line);
                }while(!Kisi_LineControl(m_line,checkNumber));

                item.Line_index=m_line;
            }
        }
        if(sayac==0){
            KartTasiNotFound();
        }else{
            Console.WriteLine("Kartlar Tasindi");
            MOTemplate();
        }
    }
    public void KartGuncelle(){
        Console.WriteLine("Oncelikle Guncellemek Istediginiz Karti Secmeniz Gerekiyor.");
        Console.Write("Lutfen Kart Basligini Yaziniz: ");
        string i_title=Console.ReadLine();

        int sayac=0;
        foreach (var item in kartlar)
        {
            if(item.Title==i_title){
                sayac++;
                Console.WriteLine("Bulunan Kart Bilgileri");
                Console.WriteLine("**************************************");
                YazdirTemplate(item);
                KartGuncelleTemplate(item);
            }
        }
        if(sayac==0){
            KartGuncelleNotFound();
        }else{
            Console.WriteLine("Kartlar Guncellendi");
            MOTemplate();
        }
    }
    bool StringControl(string name){
        if(name.Length>18){
            Console.WriteLine("Karakter Sinirini Gectiniz!");
            return false;
        }
        if(String.IsNullOrEmpty(name)){
            Console.WriteLine("Bu Alani Bos Birakamazsiniz!");
            return false;
        }
        return true;
    }
    bool BoyutControl(int number,bool checkNumber){

        if(!checkNumber){
            Console.WriteLine("Uygunsuz Tip Tespit Edildi.(Sayi Tipinde Giriniz)");
            return false;
        }
        if(number<=0 || number>=6){
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            return false;
        }
        return true;
    }
    bool Kisi_LineControl(int number,bool checkNumber){

        if(!checkNumber){
            Console.WriteLine("Uygunsuz Tip Tespit Edildi.(Sayi Tipinde Giriniz)");
            return false;
        }
        if(number<=0 || number>=4){
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            return false;
        }
        return true;
    }
    void YazdirTemplate(Kart kart){
        Console.WriteLine("Baslik: "+kart.Title);
        Console.WriteLine("Icerik: "+kart.Text);
        Console.WriteLine("Atanan Kisi: "+kart.Kisi_index);
        Console.WriteLine("Buyukluk: "+kart.Boyut_index);
    }
    void KartSilNotFound(){
        Console.WriteLine("Aradiginiz Krtiterlere Uygun Kart Board'da Bulunamadi. Lutfen Bir Secim Yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye donmek icin : (9)");
        string s_Input=Console.ReadLine();

        if(s_Input=="1"){
           KartSil();
        }else if(s_Input=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KartSilNotFound();
        }
    }
    void KartTasiTemplate(Kart kart){
        Console.WriteLine("Bulunan Kart Bilgileri");
        Console.WriteLine("**************************************");
        YazdirTemplate(kart);
        Console.WriteLine("Line: "+kart.Line_index);
        Console.Write("Lutfen Tasimak Istediginiz Line'i Seciniz: (1) TODO (2) IN PROGRESS (3) DONE ");
    }
    void KartTasiNotFound(){
        Console.WriteLine("Aradiginiz Krtiterlere Uygun Kart Board'da Bulunamadi. Lutfen Bir Secim Yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye donmek icin : (9)");
        string s_Input=Console.ReadLine();

        if(s_Input=="1"){
           KartTasi();
        }else if(s_Input=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KartTasiNotFound();
        }
    }
    void KartGuncelleNotFound(){
        Console.WriteLine("Aradiginiz Krtiterlere Uygun Kart Board'da Bulunamadi. Lutfen Bir Secim Yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye donmek icin : (9)");
        string s_Input=Console.ReadLine();

        if(s_Input=="1"){
           KartGuncelle();
        }else if(s_Input=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KartGuncelleNotFound();
        }
    }
    void KartGuncelleTemplate(Kart kart){
        Console.WriteLine("Degistirmek Istediginiz Kismi Seciniz");
        Console.Write("(0)Baslik (1)Icerik (2)Kisi (3)Boyut ");
        string s_Input=Console.ReadLine();

        switch(s_Input){
            case "0":
                string n_title;
                do{
                    Console.Write("Yeni Basligi Giriniz: ");
                    n_title=Console.ReadLine();
                }while(!StringControl(n_title));
                kart.Title=n_title;
                break;
            case "1":
                string n_text;
                do{
                    Console.Write("Yeni Icerigi Giriniz: ");
                    n_text=Console.ReadLine();
                }while(!StringControl(n_text));
                kart.Text=n_text;
                break;
            case "2":
                int n_kisi;
                bool checkNumber;
                do{
                    Console.Write("Yeni Kisiyi Seciniz => Ahmet(1) Mehmet(2) Ayse(3) ");
                    checkNumber=int.TryParse(Console.ReadLine(),out n_kisi);
                }while(!Kisi_LineControl(n_kisi,checkNumber));
                kart.Kisi_index=n_kisi;
                break;
            case "3":
                int n_boyut;
                bool checkNumberr;
                do{
                    Console.Write("Yeni Boyutu Giriniz => XS(1),S(2),M(3),L(4),XL(5) ");
                    checkNumberr=int.TryParse(Console.ReadLine(),out n_boyut);
                }while(!BoyutControl(n_boyut,checkNumberr));
                kart.Boyut_index=n_boyut;
                break;
            default:
                Console.WriteLine("Hatali Tuslama Yaptiniz");
                KartGuncelleTemplate(kart);
                break;
        }
    }
    void MOTemplate(){
        Console.WriteLine("=> Menuye Donmek Icin : (9)"+"\n"+"=> Oturumu Sonlandirmak Icin : (0)");
        string s_Input=Console.ReadLine();

        if(s_Input=="9")
            MyMethod.StartMenu(this);
        else if(s_Input=="0")
            Environment.Exit(0);
        else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            MOTemplate();
        }
    }
}