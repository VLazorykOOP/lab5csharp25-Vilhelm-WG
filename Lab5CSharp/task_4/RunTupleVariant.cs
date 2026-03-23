namespace Lab5CSharp.task_4;

public class Tuple
{ 
    public static void RunTupleVariant()
    {
        // List з іменованим кортежем
        var states = new List<(string Name, string Capital, int Population, double Area)>();

        // Приклад додавання
        states.Add(("Україна", "Київ", 41000000, 603548));
        states.Add(("Ватикан", "Ватикан", 800, 0.44));

        // Логіка видалення та вставки така сама, як у структурах
        states.RemoveAll(s => s.Population < 1000);
        states.Insert(1, ("Польща", "Варшава", 38000000, 312696));

        foreach (var s in states) Console.WriteLine($"{s.Name} | {s.Population}");
    }
}