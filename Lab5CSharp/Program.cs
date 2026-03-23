namespace Lab5CSharp.task_4;
using System;

public struct StateStruct
{
    public string Name;
    public string Capital;
    public int Population;
    public double Area;
    public StateStruct(string n, string c, int p, double a) 
    { Name = n; Capital = c; Population = p; Area = a; }
}

public record StateRecord(string Name, string Capital, int Population, double Area);

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Lab 5 - меню");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("0 - Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "4":
                    Console.WriteLine("Оберіть варіант реалізації:");
                    Console.WriteLine("1 - Структури, 2 - Кортежі, 3 - Записи");
                    string? subChoice = Console.ReadLine();

                    switch (subChoice)
                    {
                        case "1": Struct.RunStructVariant(); break;
                        case "2": Tuple.RunTupleVariant(); break;
                        case "3": Record.RunRecordVariant(); break;
                    }
                    break;
                
                case "3":
                        Edition[] catalog = new Edition[]
                        {
                            new Book("Кобзар", "Шевченко", 1840, "Київ"),
                            new Article("Нові технології", "Мельник", "Науковий світ", 5, 2023),
                            new ElectronicResource("C# Documentation", "Microsoft", "https://docs.microsoft.com", "Посібник з мови"),
                            new Book("Захар Беркут", "Франко", 1883, "Львів")
                        };

                        Console.WriteLine("--- ПОВНИЙ КАТАЛОГ ВИДАНЬ ---");
                        foreach (var item in catalog)
                        {
                            item.Show();
                        }

                        Console.Write("\nВведіть прізвище автора для пошуку: ");
                        string searchSurname = Console.ReadLine();

                        Console.WriteLine($"--- РЕЗУЛЬТАТИ ПОШУКУ ДЛЯ: {searchSurname} ---");
                        bool found = false;
                        foreach (var item in catalog)
                        {
                            if (item.IsSearched(searchSurname))
                            {
                                item.Show();
                                found = true;
                            }
                        }

                        if (!found) Console.WriteLine("Видань цього автора не знайдено.");
                    
                    break;
                
                case "2":
                    Kadry k_person1 = new Kadry("Вільгельм");
                    k_person1.Show();
                    Kadry k_person2 = new Kadry();
                    k_person2.Show();
                    Kadry k_person3 = new Kadry("Рудольф", 15);
                    k_person3.Show();

                    Worker w_person1 = new Worker("Лоріка");
                    w_person1.Show();
                    Worker w_person2 = new Worker("Ельфіда", 17);
                    w_person2.Show();
                    Worker w_person3 = new Worker();
                    w_person3.Show();
                        
                    Engineer e_person1 = new Engineer("Артур");
                    e_person1.Show();
                    Engineer e_person2 = new Engineer("Едмунд", 28);
                    e_person2.Show();
                    Engineer e_person3 = new Engineer();
                    e_person3.Show();
                        
                    Admin a_person1 = new Admin("Беатріса");
                    a_person1.Show();
                    Admin a_person2 = new Admin("Гертруда", 35);
                    a_person2.Show();
                    Admin a_person3 = new Admin();
                    a_person3.Show();
                    
                    break;
                
                case "1":
                        // Створюємо масив базового класу
                        // Дані для створення об'єктів
                        Random random = new Random();
                        string[] names = { "Іван", "Петро", "Андрій", "Олег", "Сергій", "Микола", "Василь", "Юрій" };
                        string[] surnames = { "Гайсюк", "Кушулський", "Герман", "Дуплава", "Мінков", "Урсаті", "Іонашку", "Казаку" };
                        string[] speciality = { "Програміст", "Електрик", "Механік", "Будівельник" };
                        string[] positions = { "Директор", "Менеджер", "Бухгалтер", "Начальник" };
                        string[] viddils = { "IT-відділ", "Юридичний відділ", "HR-відділ", "Бухгалтерія" };
                        
                        int n = 0; 
                        Console.Write("Введіть кількість обʼєктів: ");
                        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                        {
                            Console.WriteLine("Помилка: розмірність має бути додатним числом.");
                            Console.Write("Введіть кількість обʼєктів: ");
                        }
                    
                        Kadry[] staff = new Kadry[n];
                        for (int i = 0; i < n; i++)
                        {
                            string name = names[random.Next(names.Length)];
                            string surname = surnames[random.Next(surnames.Length)];
                            int age = random.Next(20, 60);
    
                            int category = random.Next(3);
                            switch (category)
                            {
                                case 0: // Engineer
                                    string spec = speciality[random.Next(speciality.Length)];
                                    int cat = random.Next(5);
                                    staff[i] = new Engineer(name, surname, age, spec, cat);
                                    break;
                                case 1: // Worker
                                    int rozread = random.Next(1, 3);
                                    int no_tsuhe = random.Next(1, 10);
                                    staff[i] = new Worker(name, surname, age, rozread,no_tsuhe);
                                    break;
                                case 2: // Admin
                                    string pos = positions[random.Next(positions.Length)];
                                    string viddil = viddils[random.Next(viddils.Length)];
                                    staff[i] = new Admin(name, surname, age, pos, viddil);
                                    break;
                            }
                        }

                        Console.WriteLine($"\n--- Генерація {n} обʼєктів ---");
    
                        // Сортування за іменем класу
                        var sortedStaff = staff.OrderBy(e => e.GetType().Name);

                        foreach (var emp in sortedStaff)
                        {
                            emp.Show(); // Викличе потрібний метод залежно від реального типу об'єкта
                        }
                        
                        break;
                

                case "0":
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}