//Задача 13 Напишите программу, которая выводит третью цифру заданного
// числа или сообщает,что третьей цифры нет.
Console.Clear();
Console.Write("enter number:");
int a = int.Parse(Console.ReadLine());
if (a < 100)  
{
    Console.WriteLine("no third digit");
}
else
{
    while (a > 1000)
    {
        a /= 10;
    }
    Console.WriteLine(a%10);

}
