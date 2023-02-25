﻿// Напишите программу, которая принимает на вход число и выдаёт
// количество цифр в числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

int NumberofDigits(int num)
{
    return (int)(Math.Floor(Math.Log10(num))) + 1;
}

void PrintAnswer(string explain, int num)
{
    Console.WriteLine(explain + num);
}

int num = ReadData("Enter a value: ");
PrintAnswer("The number of digits: ", NumberofDigits(num));
