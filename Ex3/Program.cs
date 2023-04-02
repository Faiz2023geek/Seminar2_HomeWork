// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.Write("Номер дня недели:");
int day = int.Parse(Console.ReadLine()!);

if (day > 7 || day < 1)
    Console.WriteLine("В неделе не больше 7 дней!");
else
{
    if (day == 1)
        Console.WriteLine("Нет, это будний день!");
    if (day == 2)
        Console.WriteLine("Нет, это будний день!");
    if (day == 3)
        Console.WriteLine("Нет, это будний день!");
    if (day == 4)
        Console.WriteLine("Нет, это будний день!");
    if (day == 5)
        Console.WriteLine("Нет, это будний день!");
    if (day == 6)
        Console.WriteLine("Да, это выходной день!");
    if (day == 7)
        Console.WriteLine("Да, это выходной день!");
}