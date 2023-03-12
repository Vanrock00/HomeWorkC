Console.Clear();
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;

if (B > max)
    {
        max = B;
    }
if (C > max)
    {
        max = C;
    }
else
    {
        Console.WriteLine("Все числа равны");
    }
if (A != B || B != C || A != C)
    {
        Console.WriteLine($"Максимальное число : {max}");
    }    