namespace Lab5CSharp.task_4;

public class Record
{
    public static void RunRecordVariant()
    {
        List<StateRecord> states = new List<StateRecord>
        {
            new("Німеччина", "Берлін", 83000000, 357022),
            new("Монако", "Монако", 39000, 2.02)
        };

        states.RemoveAll(r => r.Population < 50000);
        states.Insert(1, new StateRecord("Франція", "Париж", 67000000, 551695));

        foreach (var r in states) Console.WriteLine(r); // Records автоматично гарно друкуються
    }
}