Console.Write("Введите число N ");
double x = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= x)
{
    Console.WriteLine($"Куб числа {count}: {Math.Pow(count, 3)}");
    count++;
}