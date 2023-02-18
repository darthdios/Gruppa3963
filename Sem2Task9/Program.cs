// Задача #9
// Написать программу, которая выводит случайное 
// число из отрезка 10 - 99 и показать наибольшую
// цифру этого отрезка

// Обращаемся к ядру нашего языка
System.Random numSintezator = new System.Random();

// Вариант 1
int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;
if(firstNum>secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(secondNum);
}

// Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

// <переменная> = (условие)?<значение1>:<значение2>;


int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

