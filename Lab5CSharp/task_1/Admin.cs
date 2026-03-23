namespace User.task_1;

public class Admin : Kadry
{
    private string position;
    private string viddil;
    
    public Admin(string Name, string Surname, int Age, string Position, string Viddil) : base(Name, Surname, Age)
    {
        position = Position;
        viddil = Viddil;
    }
    
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Position: {position}, Viddil: {viddil}");
    }
}