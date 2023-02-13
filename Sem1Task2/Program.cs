// Напишите программу, которая на вход принимает два чилаи выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Вводим число #1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим число #2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Число 1 > 2");
}
else
{
    Console.WriteLine("Число 2 > 1");
}