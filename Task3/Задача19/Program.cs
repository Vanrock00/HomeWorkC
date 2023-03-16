Console.Clear();
Console.WriteLine("Введите пятизначное число N: ");
string n = Console.ReadLine()!;
int n1 = Convert.ToInt32(n);
while (n1 < 0 || n1 > 99999)
{
    Console.WriteLine("Вы ошиблись! \nВведите пятизначное число N: ");
    n = Console.ReadLine()!;
}
if(n[0] == n[4] && n[1] == n[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}