namespace Laboratory1;

    public class MainProgramLab1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                // Виведення меню
                Console.WriteLine("Оберіть завдання для виконання:");
                Console.WriteLine("1. Завдання 1");
                Console.WriteLine("2. Завдання 2");
                Console.WriteLine("3. Завдання 3");
                Console.WriteLine("4. Завдання 4");
                Console.WriteLine("0. Вихід");

                // Зчитування вибору користувача
                Console.Write("\nВведіть ваш вибір: ");
                string input = Console.ReadLine();

                // Перевірка введеного значення
                switch (input)
                {
                    case "1":
                        Program1.RunTask();
                        break;

                    case "2":
                        Program2.RunTask();
                        break;

                    case "3":
                        Program3.RunTask();
                        break;

                    case "4":
                        Program4.RunTask();
                        break;

                    case "0":
                        Console.WriteLine("Вихід з програми.");
                        return; // Виходимо з програми

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                // Додаємо паузу для зручності
                Console.WriteLine("\nНатисніть Enter для повернення в меню...");
                Console.ReadLine();
            }
        }
    }