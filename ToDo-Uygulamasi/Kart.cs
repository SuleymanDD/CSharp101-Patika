namespace ToDo_Uygulamasi;

class Kart
{
    private List<string> kisiler=new List<string>();
    private string title,text;
    private object boyut_index;
    private object kisi_index;
    private object line_index;
    public Kart(string title,string text,object boyutIndex,object kisiIndex,object lineIndex){
        kisiler.Add("");
        kisiler.Add("Ahmet");
        kisiler.Add("Mehmet");
        kisiler.Add("Ayse");
        this.Title=title;
        this.Text=text;
        this.Boyut_index=boyutIndex;
        this.Kisi_index=kisiIndex;
        this.Line_index=lineIndex;
    }

    public string Title { get => title; set => title = value; }
    public string Text { get => text; set => text = value; }
    public object Kisi_index{
        get{
            return kisiler[(int)kisi_index];
        }
        set{
            kisi_index=value;
        }
    }
    public object Boyut_index{
        get{
            return (Boyut)boyut_index;
        }
        set{
            boyut_index=value;
        }
    }
    public object Line_index{
        get{
            return (Line)line_index;
        }
        set{
            line_index=value;
        }
    }
}