// Напишите цикл, который принимает на вход два числа (А и В) и 
// возводит число А в натуральную Степень В

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

long Pow(int a, int b)
{
    long res = 0;
    while(b > 0)
    {
        res = res * a;
        b = b - 1;
    }


    return res;
}