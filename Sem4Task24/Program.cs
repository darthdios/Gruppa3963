// Напишите программу, которая принимает на вход число(А)
// и выдаёет сумму чисел от 1 до А.

// Запрос данных у пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int numberP = int.Parse(Console.ReadLine()??"0");
    return numberP; // Возвращаем значение
}

// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumSimple(int numA)
{
    int sum = 0;

    for(int i=0; i<=numA; i++)
    {
        sum+=1;
        // sum=sum+i;
    }

    return sum;
}

int SumGausse(int numA)
{
    int sum = 0;
    return sum = ((1+numA)*numA)/2;
}

int numberA = ReadData("Введите число А: ");

int res1 = SumSimple(numberA);

int res2 = SumGausse(numberA);

PrintResult("Сумма чисел от 1 до А равна(простой метод):" + res1);
PrintResult("Сумма чисел от 1 до А равна(метод Гаусса):" + res2);