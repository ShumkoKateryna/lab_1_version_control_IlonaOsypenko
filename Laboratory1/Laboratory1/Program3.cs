namespace Laboratory1;

public class Program3
{
    public static void RunTask()
    { 
        // Введення коефіцієнтів
        double a, b, c;

        // Введення коефіцієнта a
        Console.Write("\nВведіть коефіцієнт a: ");
        while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
        {
            Console.Write("Неправильний ввід. Коефіцієнт a має бути числом і не може бути нулем. Введіть правильне число: ");
        }

        // Введення коефіцієнта b
        Console.Write("Введіть коефіцієнт b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Неправильний ввід. Введіть правильне число: ");
        }

        // Введення коефіцієнта c
        Console.Write("Введіть коефіцієнт c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Неправильний ввід. Введіть правильне число: ");
        }

        // Обчислення дискримінанту
        double discriminant = b * b - 4 * a * c;

        // Розрахунок коренів
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Рівняння має два різних кореня: x1 = {root1} і x2 = {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Рівняння має один повторюваний корінь: x = {root}");
        }
        else
        {
            Console.WriteLine("Рівняння не має дійсних коренів.");
        }
    }
}