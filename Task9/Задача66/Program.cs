int f(int m, int n)
{
    if (n == m)
        return m;
    return f(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m,n));