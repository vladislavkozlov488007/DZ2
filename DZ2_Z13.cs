Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0;

if (number > 99)
{
    while (number >= 1000)
    {
        number /=10;

    }
    if (number >= 100 && number <999)
    {
        d = number % 10;
    }
    Console.WriteLine($"{d}");
}
else
{
    Console.WriteLine($"третьей цифры нет");
}
