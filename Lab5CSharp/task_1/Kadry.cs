namespace User.task_1;

public class Kadry
{
    protected string name;
    protected string surname;
    protected int age;

    public Kadry(string Name, string Surname, int Age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}");
    }
}