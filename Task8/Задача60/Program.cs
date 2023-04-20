void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            matrix[i,j,k] = new Random().Next(1, 11);
        }
    }
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            for (int k = 0; k < matrix.GetLength(2); k++) 
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размерность матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] a = new int[size[0], size[1],size[2]];
InputMatrix(a);
PrintMatrix(a);