/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */
Console.Clear();
Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

double[] array = new double[arrayLenght];

FillArray(array);
PrintArray(array);

double result = DiffMaxMin(array);
Console.WriteLine(result);

void FillArray(double[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.NextDouble() * 100;
    }
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(Math.Round(array[i], 2));
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    int count = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < count; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return (Math.Round(max - min, 2));
}