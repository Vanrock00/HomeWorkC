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

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] a = new int[size[0], size[1]];
InputMatrix(a);
PrintMatrix(a);
Console.WriteLine();
Console.Write("Введите позицию элемента: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (position[0] >= size[0] || position[1] >= size[1] || position[0] < 0 || position[1] < 0)
    {
        Console.WriteLine("Вы ошиблись!");
        position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    }
Console.WriteLine($"Ваш элемент: {a[position[0], position[1]]}");