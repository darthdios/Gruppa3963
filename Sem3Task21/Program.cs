// Напишите программу, которая принимает на вход кооррдинаты
// двух точек и находит расстояние между ними в 3D
// пространстве

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

// Метод находит расстояне между точками на плокскости
double Calclen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Cbrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)*(z1-z2)+(z1-z2));
}

int x1 = ReadData("Введите координату x точке A: ");
int y1 = ReadData("Введите координату y точке A: ");
int z1 = ReadData("Введите координату x точке A: ");
int x2 = ReadData("Введите координату y точке B: ");
int y2 = ReadData("Введите координату y точке B: ");
int z2 = ReadData("Введите координату y точке B: ");


double result = Calclen(x1,x2,y1,y2,z1,z2);

PrintData("Расстояние между точками A и В: ", result); 

// Для 3D вводим третью координату Z