Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
if (n>m)
    Console.WriteLine($"Наибольшее число {n}\nНаименьшее число {m}");
else if (n<m)
    Console.WriteLine($"Наибольшее число {m}\nНаименьшее число {n}");
else
    Console.WriteLine($"Числа равны");
