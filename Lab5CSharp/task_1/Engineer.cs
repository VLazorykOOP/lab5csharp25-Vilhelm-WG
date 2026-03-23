namespace User.task_1;

public class Engineer : Kadry
{
    private string speciality;
    private int category;
    
    public Engineer(string Name, string Surname, int Age, string Speciality, int Category) : base(Name, Surname, Age)
    {
        speciality = Speciality;
        category = Category;
    }
    
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Speciality: {speciality}, Category: {category}");
    }
}