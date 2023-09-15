namespace patika_odev2;

class Koleksiyonlar_Soru_2
{
    /*
        Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan
        Her iki grubun kendi içerisinde ortalamalarını alan
        Ortalama toplamlarını console'a yazdıran programı yazınız. 
    */
    
    /*
    static void Main(string[] args)
    {
        string[] str;
        int[] sylr=new int[20];

        Console.WriteLine("20 Dane Sayi Giriniz [Inputlariniz Ayni Satirda Olmasina Ozen Gosteriniz. BI ZAHMET!]");
        str=Console.ReadLine().Split(' ');
        if(str.Length>20){
            Console.WriteLine("Cooook Fazla Input Girdin Olmaz Boylee!");
            Environment.Exit(0);
        }

        for(int i=0;i<str.Length;i++){
            sylr[i]=int.Parse(str[i]);
        }
        Array.Sort(sylr);

        float kucukSayilarOrt=(float)(sylr[0]+sylr[1]+sylr[2])/3;
        float buyukSayilarOrt=(float)(sylr[17]+sylr[18]+sylr[19])/3;
        Console.WriteLine("En Kucuk 3 Sayi => {0} {1} {2}",sylr[0],sylr[1],sylr[2]);
        Console.WriteLine("En Buyuk 3 Sayi => {0} {1} {2}",sylr[17],sylr[18],sylr[19]);
        Console.WriteLine("En Kucuk Sayilarin Ortalamasi => "+kucukSayilarOrt);
        Console.WriteLine("En Buyuk Sayilarin Ortalamasi => "+buyukSayilarOrt);
        Console.WriteLine("Ortalamalar Toplami => "+(kucukSayilarOrt+buyukSayilarOrt));

    }
    */
}