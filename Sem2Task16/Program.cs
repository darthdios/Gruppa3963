// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.

Console.WriteLine("вводим первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Метод void вводим
void squareTest(int firstNumber, int secondNumber)
{
    if(firstNumber == Math.Pow(secondNumber))
    {
        Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Число {firstNumber} не является квадратом {secondNumber}");
    }
    
}

squareTest(firstNumber,secondNumber);

squareTest(secondNumber,firstNumber);