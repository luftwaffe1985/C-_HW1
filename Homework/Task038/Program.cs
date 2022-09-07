// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
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
int max = randomArray[0];
for (int i = 0; i < randomArray.Length; i++)
{
    if (max < randomArray[i]) max = randomArray[i];
}
int min = randomArray[0];
for (int i = 0; i < randomArray.Length; i++)
{
    if (min > randomArray[i]) min = randomArray[i];
}
int diff = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами -> {diff}.");
