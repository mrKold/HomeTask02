Console.Clear();
Console.WriteLine("Введите тёхзначное число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n / 10 - (n / 100 * 10)}");
