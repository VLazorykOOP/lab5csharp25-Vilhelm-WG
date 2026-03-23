public class ElectronicResource : Edition
{
    private string link;
    private string annotation;

    public ElectronicResource(string title, string author, string link, string annotation) 
        : base(title, author)
    {
        this.link = link;
        this.annotation = annotation;
    }

    public override void Show()
    {
        Console.WriteLine($"Е-РЕСУРС: \"{title}\", Автор: {authorSurname}\nПокликання: {link}\nАнотація: {annotation}");
    }
}