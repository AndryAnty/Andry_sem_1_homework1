
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Самое большое число " + a);
}
else if(a == b)
{
Console.WriteLine("вы ввели одинаковые числа ");
}
else
{
    Console.WriteLine("Самое больше число " + b);
}

