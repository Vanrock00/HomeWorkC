Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine()!;
int sum = 0;
for(int i = 0; i < n.Length; i++)
{
    sum += Convert.ToInt32(Convert.ToString(n[i]));
}
Console.WriteLine(sum);
