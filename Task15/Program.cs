//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("ведите день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.WriteLine("сегодня понедельник - НЕ ВЫХОДНОЙ");
if (num == 2) Console.WriteLine("сегодня вторник - НЕ ВЫХОДНОЙ");
if (num == 3) Console.WriteLine("сегодня среда - НЕ ВЫХОДНОЙ");
if (num == 4) Console.WriteLine("сегодня четверг - НЕ ВЫХОДНОЙ");
if (num == 5) Console.WriteLine("сегодня пятница - НЕ ВЫХОДНОЙ");
if (num == 6) Console.WriteLine("сегодня суббота - ВЫХОДНОЙ");
if (num == 7) Console.WriteLine("сегодня воскресенье - ВЫХОДНОЙ");