namespace patika_odev1;
class Quest_1
{
    /*  
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n)
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin
        Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın
    */
    
    static void Main(string[] args)
    {
        List<int>ciftSayilar=new List<int>();
        int temp;
        int sayiSayaci;
        
        Console.Write("Pozitif Bir Sayi Girin: ");
        sayiSayaci=int.Parse(Console.ReadLine());

        for(int i=1;i<=sayiSayaci;i++){
            Console.Write("{0}.Sayiyi Girin: ",i);
            temp=int.Parse(Console.ReadLine());

            if(temp%2==0){
                ciftSayilar.Add(temp);
            }
        }

        foreach (var sayi in ciftSayilar)
            Console.WriteLine(sayi);
    }
}
