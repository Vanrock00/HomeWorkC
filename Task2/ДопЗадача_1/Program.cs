Console.Clear();
Console.WriteLine("Введите последовательность чисел, для окончания ввода введите 0");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int SecondMax = 0;
do
{

    if (n > max)
    {
        SecondMax = max;
        max = n;
    }

    n = Convert.ToInt32(Console.ReadLine());
}
while(n != 0);
Console.WriteLine($"Первое максимальное число: {max}");
Console.WriteLine($"Второе максимальное число: {SecondMax}");