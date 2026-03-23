public class Article : Edition
{
    private string journalName;
    private int number;
    private int year;

    public Article(string title, string author, string journal, int num, int year) 
        : base(title, author)
    {
        this.journalName = journal;
        this.number = num;
        this.year = year;
    }

    public override void Show()
    {
        Console.WriteLine($"СТАТТЯ: \"{title}\", Автор: {authorSurname}, Журнал: {journalName} №{number}, Рік: {year}");
    }
}