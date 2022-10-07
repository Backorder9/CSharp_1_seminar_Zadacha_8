// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое число больше числа 1: ");
int num = int.Parse(Console.ReadLine());
int k = num/2;
int[] even = new int[k];
int j = 0;
for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0)
    {
        even[j] = i;
        j = j + 1;
    }
}
Console.WriteLine($"Следующие чётные числа содержатся в диапазоне от 1 по число {num} включительно:");
for (int p = 0; p <= k-1; p++)
{
    Console.Write(even[p] + " ");
}