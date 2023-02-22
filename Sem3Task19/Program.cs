// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// PalinTest (Вернёт результат)
bool PalinTest(int num)
{
    bool res = false;
    if((num/10000 == num%10) && (num/10000)%10 == ((num/10)%10))
    {
        res = true;
    }
    else
    {
        res = false;
    }
    
    return res;
}

int num = ReadData("Введите число: ");





    
    
    
