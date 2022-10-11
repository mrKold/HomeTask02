Console.Clear();
Console.WriteLine("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись! Введите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
     Console.WriteLine("нет");
else
     Console.WriteLine("да");