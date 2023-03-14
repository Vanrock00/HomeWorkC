Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 1 || n > 7)
{
    Console.Write("Это не день недели, попробуйте еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
else
{
    if(n >= 6)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}