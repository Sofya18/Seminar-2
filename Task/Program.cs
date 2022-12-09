// Task 10 
// Принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
 
bool NumberInInterval(int a, int b, int c)
{
    if (a >= b && a <= c)
        return true;
    else 
    {
        Console.WriteLine($"Ошибка! Число должно находиться в интервале от {b} до {c}!");
        return false;
    }   
}

int n;
Console.Clear();
do
{
    Console.Write("Введите трехзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
} while (!NumberInInterval(n, 100, 999));

int m = n / 10 - (n / 100) * 10;
Console.WriteLine($"Вторая цифра числа: {m}.");












 




