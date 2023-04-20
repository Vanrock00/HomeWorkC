void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = new Random().Next(1, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} \t");
        Console.WriteLine();
    }
}

int MinString(int[,] matrix)
{
    int min = 99999;
    int string_summ = 0;
    int string_count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            string_summ += matrix[i,j];
        }
        if(string_summ < min)
        {
            min = string_summ;
            string_count = i;
        }
        string_summ = 0;
    }
    return string_count;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] a = new int[size[0], size[1]];
InputMatrix(a);
PrintMatrix(a);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {MinString(a) + 1}");