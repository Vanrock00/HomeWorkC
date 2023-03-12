Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
else
    {
        Console.WriteLine("Число не четное");
    }