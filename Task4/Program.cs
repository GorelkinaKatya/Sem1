Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число: ");
int p = int.Parse(Console.ReadLine()!);

if ( n > m && n > p)
    Console.WriteLine($"Наибольшее число {n}");
else if (m > n && m > p)
    Console.WriteLine($"Наибольшее число {m}");
else
    Console.WriteLine($"Наибольшее число {p}");
