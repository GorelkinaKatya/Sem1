Console.Clear();
Console.Write("Введите положительное число: ");
int n = int.Parse(Console.ReadLine()!);

while (n <= 0)
{
    Console.Write("Вы ошиблись!\nВведите положительное число: ");
    n = int.Parse(Console.ReadLine()!);
}

for (int i = 2; i <= n; i+=2)
    Console.Write($"{i} ");