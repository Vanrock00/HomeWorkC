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
void ProizvMatrix(int[,] a, int[,] b, int[,] c)
{
    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            for (int k = 0; k < c.GetLength(1); k++)
                c[i,j] += a[i,k] * b[k,j];
            Console.Write($"{c[i,j]} \t");
        }
        Console.WriteLine();

    }
}

Console.Clear();
Console.Write("Введите размерность матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] a = new int[size[0], size[1]];
int[,] b = new int[size[0], size[1]];
int[,] c = new int[size[0], size[1]];
InputMatrix(a);
InputMatrix(b);
Console.WriteLine("Матрица A:");
PrintMatrix(a);
Console.WriteLine("Матрица B:");
PrintMatrix(b);
Console.WriteLine("Произведение матриц A*B:");
ProizvMatrix(a, b, c);