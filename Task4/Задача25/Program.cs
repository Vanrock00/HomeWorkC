Console.Clear();
Console.Write("Введите основание: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 0; i < b; i++)
{
    result *= a; 
}
Console.WriteLine(result);