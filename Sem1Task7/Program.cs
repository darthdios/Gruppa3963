// Задача #7
// Напишите программу, которая принимает на вход трёхначное число
// и на выходе показывает последнее цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <1000)
{
    Console.WriteLine("Пследняя цифра числа: "+number%10);
}
else
Console.WriteLine("Введено не то число");