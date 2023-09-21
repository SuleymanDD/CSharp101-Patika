namespace TelefonRehberi_Uygulamasi;

class Rehber
{
    List<Kisi> kisiler=new List<Kisi>();
    public Rehber(){
        kisiler.Add(new Kisi("Yasin","Papuccu",2132177432));
        kisiler.Add(new Kisi("Keriman","Tuzcu",7682458342));
        kisiler.Add(new Kisi("Efsun","Kara",9837512342));
        kisiler.Add(new Kisi("Tufan","Beri",3724867385));
        kisiler.Add(new Kisi("Deniz","Turp",2849212749));
    }
    public void RehberEkle(){
        string name,surname;
        bool checkNumber;
        long number;
        do{
            Console.Write("Lutfen İsim Giriniz: ");
            name=Console.ReadLine();
        }while(!NameControl(name));
        do{
            Console.Write("Lutfen Soyisim Giriniz: ");
            surname=Console.ReadLine();
        }while(!NameControl(surname));
        do{
            Console.Write("Lutfen Telefon Numarasi Giriniz: ");
            checkNumber=long.TryParse(Console.ReadLine(),out long result);
            number=result;
        }while(!NumberControl(number,checkNumber));
        
        kisiler.Add(new Kisi(name,surname,number));
        Console.WriteLine("Kisi Eklendi");
        MOTemplate();
    }
    public void KisiSil(){
        Console.Write("Lutfen Numarasini Silmek Istediginiz Kisinin Adini Ya Da Soyadini Giriniz: ");
        string sInput=Console.ReadLine();

        int listUzunluk=kisiler.Count;
        for(int i=0;i<listUzunluk;i++){
            if(kisiler[i].İsim==sInput || kisiler[i].SoyIsim==sInput){
                KisiSilOnay(kisiler,i);
                break;
            }
            if(i==listUzunluk-1){
                KisiSilNotFound();
            }
        }
    }
    
    public void KisiUpdate(){
        Console.Write("Lutfen Numarasini Guncellemek Istediginiz Kisinin Adini Ya Da Soyadini Giriniz: ");
        string sInput=Console.ReadLine();

        int listUzunluk=kisiler.Count;
        for(int i=0;i<listUzunluk;i++){
            if(kisiler[i].İsim==sInput || kisiler[i].SoyIsim==sInput){
                long nInput;
                bool checkNumber;
                do{
                    Console.Write("Yeni Numarayi Giriniz: ");
                    checkNumber=long.TryParse(Console.ReadLine(),out long result);
                    nInput=result;
                }while(!NumberControl(nInput,checkNumber));
                kisiler[i].TelNo=nInput;
                Console.WriteLine("Numara Guncellendi");
                MOTemplate();
                break;
            }
            if(i==listUzunluk-1){
                KisiUpdateNotFound();
            }
        }
    }
    
    public void RehberListele(){
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("****************************************");

        foreach (var item in kisiler)
            Console.WriteLine("Isim: {0} Soyisim: {1} Telefon Numarasi: {2}",item.İsim,item.SoyIsim,item.TelNo);
    }
    public void RehberSearch(){
        Console.WriteLine("Arama Yapmak Istediginiz Tipi Seciniz");
        Console.WriteLine("****************************************");
        Console.WriteLine("=> Isim Veya Soyisime Gore Arama Yapmak Icin : (1)"+"\n"+"=> Telefon Numarasina Gore Arama Yapmak Icin : (2)");
        string seInput=Console.ReadLine();

        byte control=0;
        if(seInput=="1"){
            Console.Write("Lutfen Bulmak Istediginiz Kisinin Adini Ya Da Soyadini Giriniz: ");
            string sInput=Console.ReadLine();

            int listUzunluk=kisiler.Count;
            for(int i=0;i<listUzunluk;i++){
                if(kisiler[i].İsim==sInput || kisiler[i].SoyIsim==sInput){
                    control++;
                    if(control==1){
                        Console.WriteLine("Arama Sonuclariniz");
                        Console.WriteLine("****************************************");
                    }
                    Console.WriteLine("Isim: {0} Soyisim: {1} Telefon Numarasi: {2}",kisiler[i].İsim,kisiler[i].SoyIsim,kisiler[i].TelNo);
                }
                if(control==0 && i==listUzunluk-1){
                    RehberSearchNotFound();
                }
            }
        }else if(seInput=="2"){
            long nInput;
            bool checkNumber;
            do{
                Console.Write("Lutfen Bulmak Istediginiz Kisinin Numarasini Giriniz: ");
                checkNumber=long.TryParse(Console.ReadLine(),out long result);
                nInput=result;
            }while(!NumberControl(nInput,checkNumber));

            int listUzunluk=kisiler.Count;
            for(int i=0;i<listUzunluk;i++){
                if(kisiler[i].TelNo==nInput){
                    control++;
                    if(control==1){
                        Console.WriteLine("Arama Sonuclariniz");
                        Console.WriteLine("****************************************");
                    }
                    Console.WriteLine("Isim: {0} Soyisim: {1} Telefon Numarasi: {2}",kisiler[i].İsim,kisiler[i].SoyIsim,kisiler[i].TelNo);
                }
                if(control==0 && i==listUzunluk-1){
                    RehberSearchNotFound();
                }
            }
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            RehberSearch();
        }
    }
    
    bool NameControl(string name){
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
    bool NumberControl(long number,bool checkNumber){
        string tmpNumber=Convert.ToString(number);
        if(!checkNumber){
            Console.WriteLine("Uygunsuz Tip Tespit Edildi.(Sayi Tipinde Giriniz)");
            return false;
        }
        if(tmpNumber.Length>10){
            Console.WriteLine("Karakter Sinirini Gectiniz!");
            return false;
        }
        if(String.IsNullOrEmpty(tmpNumber)){
            Console.WriteLine("Bu Alani Bos Birakamazsiniz!");
            return false;
        }
        return true;
    }
    void MOTemplate(){
        Console.WriteLine("=> Menuye Donmek Icin : (9)"+"\n"+"=> Oturumu Sonlandirmak Icin : (0)");
        string seInput=Console.ReadLine();
        if(seInput=="9")
            MyMethod.StartMenu(this);
        else if(seInput=="0")
            Environment.Exit(0);
        else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            MOTemplate();
        }
    }
    void RehberSearchNotFound(){
        Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lutfen bir secim yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye Donmek Icin : (9)");
        string sInput=Console.ReadLine();

        if(sInput=="1"){
            RehberSearch();
        }else if(sInput=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            RehberSearchNotFound();
        }
    }
    void KisiSilOnay(List<Kisi> kisiler,int i){
        Console.Write("{0} isimli kisi rehberden silinmek uzere, onayliyor musunuz ?(y/n) ",kisiler[i].İsim);
        string seInput=Console.ReadLine();

        if(seInput=="y"){
            kisiler.RemoveAt(i);
            Console.WriteLine("Kisi Silindi");
            MOTemplate();
        }else if(seInput=="n"){
            MOTemplate();
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KisiSilOnay(kisiler,i);
        }
    }
    void KisiSilNotFound(){
        Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lutfen bir secim yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye Donmek Icin : (9)");
        string sInput=Console.ReadLine();

        if(sInput=="1"){
            KisiSil();
        }else if(sInput=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KisiSilNotFound();
        }
    }
    void KisiUpdateNotFound(){
        Console.WriteLine("Aradiginiz krtiterlere uygun veri rehberde bulunamadi. Lutfen bir secim yapiniz.");
        Console.WriteLine("=> Yeniden denemek icin : (1)"+"\n"+"=> Menuye Donmek Icin : (9)");
        string seInput=Console.ReadLine();
        if(seInput=="1"){
            KisiUpdate();
        }else if(seInput=="9"){
            MyMethod.StartMenu(this);
        }else{
            Console.WriteLine("Hatali Tuslama Yaptiniz");
            KisiUpdateNotFound();
        }
    }

}