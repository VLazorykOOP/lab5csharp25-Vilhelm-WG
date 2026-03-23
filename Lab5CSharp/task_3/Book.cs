public class Book : Edition
{
    private int year;
    private string publisher;

    public Book(string title, string author, int year, string publisher) 
        : base(title, author)
    {
        this.year = year;
        this.publisher = publisher;
    }

    public override void Show()
    {
        Console.WriteLine($"КНИГА: \"{title}\", Автор: {authorSurname}, Рік: {year}, Видавництво: {publisher}");
    }
}