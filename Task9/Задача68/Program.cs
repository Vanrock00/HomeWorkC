int ack(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if(b == 0)
        return ack(a-1,1);
    return ack(a-1, ack(a, b-1));
}


Console.Clear();
Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ack(a,b));