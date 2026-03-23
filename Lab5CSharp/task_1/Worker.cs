namespace User.task_1;

public class Worker : Kadry
{
    private int rozread;
    private int no_tsehu;
    
    public Worker(string Name, string Surname, int Age, int Rozread, int No_tehu) : base(Name, Surname, Age)
    {
        rozread = Rozread;
        no_tsehu = No_tehu;
    }
    
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Rozread: {rozread}, No_tehu: {no_tsehu}");
    }
}