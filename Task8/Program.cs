// Напишите программу. которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N>0)
{
    for(int i = 2; i<=N; i+=2)
    {
        Console.Write($"{i} ");
    }
}
else Console.WriteLine ("Вы ввели неверное число");
