// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


string getPower3 ()
{
Console.Write("Введите положительное число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int power = 3;
string res = string.Empty;  // Пустая строка
while (i <= N)
    {
        res += Math.Pow(i, power) + ", ";
        i++;
                 
    }
return res;
}
try
{
    Console.WriteLine(getPower3 ());
}
catch
{
    Console.WriteLine("необходимо ввести положительное натуральное число цифрой");
}

