public abstract class Edition
{
    protected string title;
    protected string authorSurname;

    public Edition(string title, string authorSurname)
    {
        this.title = title;
        this.authorSurname = authorSurname;
    }

    // Абстрактний метод: кожен нащадок реалізує його по-своєму
    public abstract void Show();

    // Метод для пошуку: перевіряє, чи збігається прізвище
    public bool IsSearched(string surname)
    {
        return string.Equals(authorSurname, surname, StringComparison.OrdinalIgnoreCase);
    }
}