namespace Laboratory1;

public class Program4
{
    public static void RunTask()
    {
        int n;
        
        Console.Write("\nОбчислення факторіалу числа. Введіть число n для розрахунку: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("Неправильний ввід. Введіть невід'ємне ціле число: ");
        }

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        
        Console.WriteLine("Факторіал числа:\n{0}! = {1}", n, result);
    }
}