// Задача #3
// Напишите программу, которая будет выдавать
// названия дня недели по заданному номеру.

Console.Write("Выведите число");
var day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    string[] dayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    Console.WriteLine(dayWeek[day - 1]);
}
else
{
    Console.WriteLine("Вы ввели не день недели");
}