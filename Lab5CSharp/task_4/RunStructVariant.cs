namespace Lab5CSharp.task_4;

public class Struct
{
    public static void RunStructVariant()
    {
        List<StateStruct> states = new List<StateStruct>();
        Console.Write("Введіть кількість держав: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Держава #{i + 1}:");
            Console.Write("Назва: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Столиця: ");
            string cap = Console.ReadLine() ?? "";
            Console.Write("Населення: ");
            int pop = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Площа: ");
            double area = double.Parse(Console.ReadLine() ?? "0");
            states.Add(new StateStruct(name, cap, pop, area));
        }

        // ВИДАЛЕННЯ
        Console.Write("\nВидалити тих, у кого населення менше ніж: ");
        int limit = int.Parse(Console.ReadLine() ?? "0");
        states.RemoveAll(s => s.Population < limit);

        // ДОДАВАННЯ ПІСЛЯ НОМЕРА
        Console.Write("\nПісля якого номера (1, 2...) додати новий елемент? ");
        int pos = int.Parse(Console.ReadLine() ?? "1");
        states.Insert(pos, new StateStruct("Нова країна", "Центр", 5000, 100.5));

        // ВИВІД
        Console.WriteLine("\n--- Результат (Структури) ---");
        foreach (var s in states) Console.WriteLine($"{s.Name} | {s.Population} осіб");
    }
}