// Напишите програаму, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N

// Два метода: ReadData и LineBuilder

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователя
string LineBuilder(int num, int pow)
{
    string res = string.Empty;

    for (int i=1; i<=num; i++)
    {
        res = res + Math.Pow(i,pow) + "\t";
    }
    return res;
}
int N = ReadData("Введите число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,3));