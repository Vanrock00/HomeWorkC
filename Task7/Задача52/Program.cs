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


void CountMatrix(int[,] matrix)
{
    double sum = 0;
    double result = 0;

    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
            sum = sum + matrix[j,i];
        result = sum / matrix.GetLength(1);
        Console.WriteLine(result);
        sum = 0;
        result = 0;
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] a = new int[size[0], size[1]];
InputMatrix(a);
PrintMatrix(a);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");
CountMatrix(a);