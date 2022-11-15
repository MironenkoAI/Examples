//Задача 1: число кратно 7 и 23 одновременно?

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

//Задача 2: является ли одно из чисел квадратом другого?

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}