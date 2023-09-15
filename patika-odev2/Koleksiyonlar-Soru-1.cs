using System.Collections;

namespace patika_odev2;
class Koleksiyonlar_Soru_1
{
    /*
        Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            -Negatif ve numeric olmayan girişleri engelleyin.
            -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    */
    
    static void Main(string[] args)
    {
        ArrayList asalSayilar=new ArrayList();
        ArrayList asalOlmayanSayilar=new ArrayList();
        string[] str;
        bool isOkay;

        Console.WriteLine("20 Dane Sayi Giriniz [Inputlariniz Ayni Satirda Olmasina Ozen Gosteriniz. BI ZAHMET!]");
        str=Console.ReadLine().Split(' ');
        if(str.Length>20){
            Console.WriteLine("Cooook Fazla Input Girdin Olmaz Boylee!");
            Environment.Exit(0);
        }
        
        foreach (var item in str)
        {
            isOkay=int.TryParse(item,out int tmp);
            if(!InputCheck(isOkay,tmp)){
                Environment.Exit(0);
            }

            if(IsAsal(tmp)){
                asalSayilar.Add(tmp);
            }else{
                asalOlmayanSayilar.Add(tmp);
            }
        }

        Console.WriteLine("*** Asal ve Asal Olmayan Sayilar ***");
        HizalaYazdir(asalSayilar);
        HizalaYazdir(asalOlmayanSayilar);
        
        Console.WriteLine("*** Eleman Sayisi ve Ortalamalari ***");
        OrtBul(asalSayilar);
        OrtBul(asalOlmayanSayilar);
    }
   public static bool IsAsal(int sayi){
        if(sayi<2){
            return false;
        }
        if(sayi==2){
            return true;
        }
        for(int i=2;i<sayi;i++){
            if(sayi%i==0){
                return false;
            }
        }
        return true;
   }
   public static bool InputCheck(bool ifade,int sayi){
        if(!ifade){
            Console.WriteLine("Sadece Sayi Gabul Ediyoruz Gardas. Haberin Ola!");
            return false;
        }
        if(sayi<0){
            Console.WriteLine("Negatif Sayi Giremen. Vallahi");
            return false;
        }
        return true;
   }
   public static void HizalaYazdir(ArrayList a){
        a.Sort();
        a.Reverse();
        foreach (var item in a)
            Console.Write(item+" ");
        Console.Write("\n");
   }
   public static void OrtBul(ArrayList b){
        int sum=0,elemanSayisi;
        elemanSayisi=b.Count;
        foreach (int item in b)
            sum+=item;
        Console.WriteLine(elemanSayisi+" "+(float)sum/elemanSayisi);
   }
}
