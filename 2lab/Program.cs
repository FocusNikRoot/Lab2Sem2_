using System;

namespace Lab2Sem2_
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Instance.Start();
        }
    }
}
public class Menu
{
    public void Start()
    {
        Console.WriteLine
            (
            "Выберите документ: " +
            "1 - Excel, " +
            "2 - Word, " +
            "3 - PDF, " +
            "4 - Txt, " +
            "5 - Html."
            );
        int Number = Convert.ToInt32(Console.ReadLine());
        switch (Number)
        {
            case 1:
                Menu.Instance.Excel();
                break;
            case 2:
                Menu.Instance.MicroSoftWord();
                break;
            case 3:
                Menu.Instance.PDF();
                break;
            case 4:
                Menu.Instance.Txt();
                break;
            case 5:
                Menu.Instance.Html();
                break;
        }
    }
    public static Menu Instance                                          //Singleton
    {
        get
        {
            if (instance == null) instance = new Menu();
            return instance;
        }
    }
    private Menu() { }
    private static Menu instance;
    public void Excel()
    {
        var excel = new 
        { 
            Name = "MyTable.exl", 
            Author = "Kpacka", 
            Keywords = "Table", 
            Subject = "Solve", 
            PathFile = "c:/Users/Kpacka/Desktop/Work/" 
        };
        Console.WriteLine(excel);
    }
    public void MicroSoftWord()
    {
        var word = new
        {
            Name = "TotalWar.docx",
            Author = "Dostoevskiy",
            Keywords = "Docx",
            Subject = "Book",
            PathFile = "c:/Users/Kpacka/Documents/"
        };
        Console.WriteLine(word);
    }
    public void PDF()
    {
        var pdf = new
        {
            Name = "ESW cards FINAL.pdf",
            Author = "ESW",
            Keywords = "pdf",
            Subject = "Cards",
            PathFile = "c:/Users/Kpacka/Downloads/"
        };
        Console.WriteLine(pdf);
    }
    public void Txt()
    {
        var txt = new
        {
            Name = "Anime List.txt",
            Author = "Kpacka",
            Keywords = "txt",
            Subject = "Top",
            PathFile = "c:/Users/Kpacka/Desktop/Favorites/"
        };
        Console.WriteLine(txt);
    }
    public void Html()
    {
        var html = new
        {
            Name = "gachimuchi.com.html",
            Author = "Billy",
            Keywords = "html",
            Subject = "Big Fat ...",
            PathFile = "c:/Users/Kpacka/Desktop/Favorites/"
        };
        Console.WriteLine(html);
    }
    
}

