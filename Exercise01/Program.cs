//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа
/*Console.Clear();

int randNumber = new Random().Next(100,1000);

Console.WriteLine(randNumber);

int firstNum = randNumber/100;
int thirdNum = randNumber%10;

Console.WriteLine(firstNum);
Console.WriteLine(thirdNum);

string newNumber1 = Convert.ToString(firstNum);
string newNumber2 = Convert.ToString(thirdNum);

string newNumber3 = newNumber1+newNumber2;

Console.WriteLine(newNumber3);
int finalNumber = Convert.ToInt32(newNumber3);

Console.WriteLine("Answer is "+ finalNumber);*/

//вариант 2: от преподавателя

Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine("num is "+num);
int x = num/100; //например число 891 = 8 
x = x*10;  // 8*10 =80
x = x+(num%10);; // 80 +1

//int result = (num/100)*10 + num %10;

Console.WriteLine("x is:" +x);
System.Console.WriteLine($"it's -> {x}"); //таким образом мы переводим в строку значение x
System.Console.WriteLine();