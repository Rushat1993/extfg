Console.WriteLine("");
Console.Write("Введите число ");
int uinput = Convert.ToInt32((Console.ReadLine()));
int remainder = 0;
int newnum = 0;
for (int i = uinput; i > 0; i = (i / 10))
{
    remainder = i % 10;
    newnum = (newnum*10) + remainder;
}
if (newnum == uinput)
{
    Console.WriteLine($"Число {uinput} является палиндромом");
}
else
{
    Console.WriteLine($"Число {uinput} не является палиндромом");
}