//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number%100)/10;
if (number/100>0)
{
   Console.WriteLine(result); 
}
else
{
    Console.WriteLine("Число не трехзначное");
}