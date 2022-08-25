Console.Clear();

Console.Write("Enter first number ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number ");
int number2 = int.Parse(Console.ReadLine());

if(number1 %number2 ==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток - {number1 % number2}");
}
