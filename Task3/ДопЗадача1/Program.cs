Console.Clear();
Console.Write("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество ягод на одноме без пробела: ");
string a = Console.ReadLine()!;
int max = 0;
if(Convert.ToInt32(Convert.ToString(a[0])) + Convert.ToInt32(Convert.ToString(a[n-1])) + Convert.ToInt32(Convert.ToString(a[1])) > max)
{
    max = Convert.ToInt32(Convert.ToString(a[0])) + Convert.ToInt32(Convert.ToString(a[n-1])) + Convert.ToInt32(Convert.ToString(a[1]));
}
if(Convert.ToInt32(Convert.ToString(a[n-1])) + Convert.ToInt32(Convert.ToString(a[n-2])) + Convert.ToInt32(Convert.ToString(a[0])) > max)
{
    max = Convert.ToInt32(Convert.ToString(a[n-1])) + Convert.ToInt32(Convert.ToString(a[n-2])) + Convert.ToInt32(Convert.ToString(a[0]));
}
for(int i = 1; i < n - 1; i++)
{
    if (Convert.ToInt32(Convert.ToString(a[i])) + Convert.ToInt32(Convert.ToString(a[i+1])) + Convert.ToInt32(Convert.ToString(a[i-1])) > max)
    {
        max = Convert.ToInt32(Convert.ToString(a[i])) + Convert.ToInt32(Convert.ToString(a[i+1])) + Convert.ToInt32(Convert.ToString(a[i-1]));
    }
}
Console.WriteLine(max);