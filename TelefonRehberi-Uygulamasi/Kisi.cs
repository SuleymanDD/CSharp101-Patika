namespace TelefonRehberi_Uygulamasi;

public class Kisi
{
    private string isim,soyIsim;
    private long telNo;

    public Kisi(string isim,string soyIsim,long telNo){
        this.İsim=isim;
        this.SoyIsim=soyIsim;
        this.TelNo=telNo;
    }
    public string İsim {get;set;}
    public string SoyIsim {get;set;}
    public long TelNo{get;set;}
}