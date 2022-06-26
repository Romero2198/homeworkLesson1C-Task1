Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Max= " + a + " Min= " + b);
}
else
{
    Console.WriteLine("Max= " + b + " Min= " + a);
}