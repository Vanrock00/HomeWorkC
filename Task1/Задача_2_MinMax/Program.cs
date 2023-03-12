Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
    {
        Console.WriteLine("Первое число больше");
    }
else if (A < B)
    {
        Console.WriteLine("Второе число больше");
    }
else 
    {
        Console.WriteLine("Числа равны");
    }