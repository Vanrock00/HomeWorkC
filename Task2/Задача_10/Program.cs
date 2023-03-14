Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = (n / 10) % 10;
Console.WriteLine($"Вторая цифра числа {n} - {n2}");