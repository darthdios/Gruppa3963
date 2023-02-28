// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// Задаём одномерный массив
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    // Блок корректировки входных данных
    if(minValue>maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

// Печатаем одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

// Делаем инверсию
void InversArr(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}

int [] testArr = Gen1DArray(12,-9,9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);