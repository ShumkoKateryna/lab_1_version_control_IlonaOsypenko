namespace Laboratory1;

public class Program1
{
    public static void RunTask()
    { 
        // Введення кількості рядків
        Console.Write("\nВведіть кількість рядків для пошуку підрядка: ");
        int numberOfLines;
        while (!int.TryParse(Console.ReadLine(), out numberOfLines) || numberOfLines <= 0)
        {
            Console.Write("\nНеправильний ввід. Введіть правильне число: ");
        }

        // Введення рядків
        string[] lines = new string[numberOfLines];
        Console.WriteLine("\nВведіть рядки:");
        for (int i = 0; i < numberOfLines; i++)
        {
            Console.Write($"Рядок {i + 1}: ");
            lines[i] = Console.ReadLine();
        }

        // Введення фрагмента для пошуку
        Console.Write("Введіть строковий фрагмент для пошуку: ");
        string searchFragment = Console.ReadLine();

        // Пошук і виведення результатів
        Console.WriteLine("\nРядки, що містять фрагмент:");
        bool found = false;
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].IndexOf(searchFragment, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Рядок {i + 1}: {lines[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Жоден рядок не містить заданий фрагмент.");
        }

        // Завершення програми
        Console.WriteLine("\nНатисніть Enter для виходу...");
        Console.ReadLine();
    }
}