int InputSecondNumber(int num)
{
    int count;
    count = num % 100 / 10;
    return count;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondNumber = InputSecondNumber(num);
Console.Write($"вторая цифра от числа {num} это цифра  {SecondNumber}");