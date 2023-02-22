// Задача #18
// Напишите программу, которая по заданному номеру четверти 
// показывает диапозон возможных координат
// в этой четверти


int ReadInput(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void SearchXY(int num)
{
    if (num > 0 && num < 5)
    {
       if (num == 1)Console.WriteLine("x > 0, y > 0");
       if (num == 2)Console.WriteLine("x > 0, y < 0");
       if (num == 3)Console.WriteLine("x < 0, y < 0");
       if (num == 4)Console.WriteLine("x < 0, y > 0");
    }
    else Console.WriteLine("Не номер четверти");
    
}

int quarter = ReadInput("Введите номер четверти: ");
SearchXY(quarter);

