/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
if (number < 8 && number > 5 ) 
{
    Console.WriteLine("выходной");
}
else if ( number > 7)
{
    Console.WriteLine("нет такого дня недели");
}
else 
{
    Console.WriteLine("не выходной");
}