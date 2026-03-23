using User.task_1;

namespace Lab3CSharp;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Lab 1 - меню");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("0 - Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "2":
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

                        Console.WriteLine("--- Співробітники, впорядковані за типом ---");
    
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