/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomValue()
{
    return new Random().Next(100, 1000);
}
int TwoNumber(int number)
{
   return ( number / 10 );
}
int result1 ( int result)
{
 return( result % 10);
}

int number = GetRandomValue();
int result = TwoNumber(number);
int finish = result1(result);
Console.WriteLine($"число {number}, вторая цифра {finish}");
