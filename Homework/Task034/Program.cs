// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int N)
{
    int[] array = new int[N];
    Console.Write("[ ");
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    return array;
}

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] randomArray = Array(N);
int evennum = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] % 2 == 0) evennum++;
}
Console.WriteLine($"Количество четных элементов в массиве -> {evennum}");
