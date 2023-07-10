// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if (a<b)
{
    max=b; 
    min=a;
}
Console.WriteLine("Минимальное число равно " + min);
Console.WriteLine("Максималььное число равно " + max);
