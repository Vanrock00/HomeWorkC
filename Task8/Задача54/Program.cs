void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} \t");
        Console.WriteLine();
    }
}

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = new Random().Next(1, 11);
    }
}
void SortMatrix(int[,] matrix)
{
    int minPosition = 0;
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if(matrix[i,k] < matrix[i,minPosition]) minPosition = k;
            }
            temp = matrix[i,j];
            matrix[i,j] = matrix[i,minPosition];
            matrix[i,minPosition] = temp;
        }
    }
}

Console.Clear();
Console.Write("Введите размерность матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] a = new int[size[0], size[1]];
InputMatrix(a);
PrintMatrix(a);
Console.WriteLine();
SortMatrix(a);
PrintMatrix(a);