namespace User.task_1;

public class Kadry
{
    protected string name;
    protected string surname;
    protected int age;

    public Kadry(string Name, string Surname, int Age)
    {
        name = Name;
        surname = Surname;
        age = Age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"\nName: {name}, Surname: {surname}, Age: {age}");
    }
}