Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(sum);