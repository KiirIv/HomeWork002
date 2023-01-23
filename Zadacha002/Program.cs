/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
if ( number > 99)
{
string str = number.ToString();
Console.WriteLine($"третья цифра {str[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}