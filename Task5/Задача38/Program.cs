Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double max = 0;
double min = 99999999;
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"[{string.Join(" ", array)}]");
Console.WriteLine(Math.Round(max - min, 2));
