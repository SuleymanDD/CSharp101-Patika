namespace struct_tanimi;
class Program
{
    //Struct boş bir cons oluşturamaz
    //Classta değer atanmasa bile metodlar çalıştırılabilirken Structta yapılamıyor
    
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen=new Dikdortgen(3,4);

        Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen.AlanHesapla());

        Dikdortgen_struct dikdrtgn=new Dikdortgen_struct(3,4);

        Console.WriteLine("Structer Alan Hesabı: {0}",dikdrtgn.AlanHesapla());
    }
}
class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen(int kisaKenar,int uzunKenar){
        this.KisaKenar=kisaKenar;
        this.UzunKenar=uzunKenar;
    }

    public int AlanHesapla(){
        return this.KisaKenar*this.UzunKenar;
    }
}
struct Dikdortgen_struct
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen_struct(int kisaKenar,int uzunKenar){
        this.KisaKenar=kisaKenar;
        this.UzunKenar=uzunKenar;
    }
    public int AlanHesapla(){
        return this.KisaKenar*this.UzunKenar;
    }
}
