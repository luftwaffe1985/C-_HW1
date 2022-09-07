// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Array(int N)
{
    int[] array = new int[N];
    Console.Write("[ ");
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine("]");
    return array;
}
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] randomArray = Array(N);
int unevensum = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (i % 2 == 1) unevensum += randomArray[i];
}
Console.WriteLine($"Сумма нечетных позиций элементов -> {unevensum}");
