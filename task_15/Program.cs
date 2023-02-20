// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber = ReadInt("Enter number from 1 to 7: ");
Console.WriteLine(WorkHoliday(dayNumber));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Under the number " + a + " - weekend");
        }
        else
        {
            Console.Write("Under the number " + a + " - working");
        }
    }
    else
    {
        Console.Write("number not from 1 to 7, is not defined");
    }
    return " day.";
}
