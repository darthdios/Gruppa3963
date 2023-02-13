// Напишите программу, которая на вход принимает число (N),
// а на выходе показывет все чётные числа от 1 до N

Console.WriteLine("Вводим число N");
int numberN = Convert.ToInt32(Console.ReadLine());

// Если N=10, то чётных чисел - 5

for(int i = 2; i < numberN; i = i + 2)
{
    Console.Write(i + " ");
}