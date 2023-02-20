//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("enter a three-digit number");;
int numb = int.Parse(Console.ReadLine());
if (numb < 100 || numb > 999)
{
    Console.WriteLine("It's not a three-digit number");
}
else
{
    int result =  (numb/10) % 10;
    Console.WriteLine($"{numb} = {result}");
}
