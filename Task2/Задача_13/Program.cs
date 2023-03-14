Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (n1 > 999)
    {
        n1 = n1 / 10;
    }

    Console.WriteLine($"Третья цифра числа {n} - {n1 % 10}");
}