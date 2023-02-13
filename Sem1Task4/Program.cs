// Напишите программу, которая на вход принимает
// три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Вводим число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число 3");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
else 
{
    if (number2 > number3)
    {
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine(number3);
    }
}