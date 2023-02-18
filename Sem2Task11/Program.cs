// Задача #11
// Напишите программу,которая вводит случайное
// трёхзначное число и удаляет вторую цифру этого числа

// Вариант 1
Random rnd = new Random();

int rndNum = rnd.Next(100,1000);
Console.WriteLine("Рандомное число = {rndNum}");

int lastDigit = rndNum % 10;
int firstDigit = rndNum / 100;
rndNum = firstDigit * 10 + lastDigit;
Console.WriteLine("Получившееся число = {rndNum}");

// Вариант 2
System.Random numSintezator = new System.Random();

int num = new Random().Next(100,1000);
Console.WriteLine(num);

lastDigit = num%10;
firstDigit = num/100;
num = firstDigit*10 + lastDigit;
Console.WriteLine(num);