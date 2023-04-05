Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Колличество элементов >0: {count}");

