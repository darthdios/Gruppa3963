﻿// Напишите программу, которая выводит третью цифру
// заданного числа и сообщает, что третьей
// цифры нет.

// Необходимо считать само число
string num = Console.ReadLine()??"0";

// Надо превратить это число в массив
char[] array = num.ToCharArray();

// Выводим ячейку тертье число (ячейка номер два)
 Console.WriteLine(array[2]);
