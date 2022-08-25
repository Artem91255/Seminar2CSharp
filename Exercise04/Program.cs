Console.Write("Enter first number a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Math.Pow(b,2));

if(a*a==b)
{
    Console.WriteLine("b квадрат числа a");
    return;
}
// Math.Pow - возведение в степень
// Возвращая типы Double(Float) - число с плавающей запятой
// 2 во второй степени = Math.Pow(2,2)
if (x==a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("не является");
}
