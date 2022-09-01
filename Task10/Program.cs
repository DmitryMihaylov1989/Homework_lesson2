//напишите программу, которая на вход принимает 3х значное число, 
// а на выходе показывает вторую цифру этого числа
Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99) Console.WriteLine((n % 100) / 10);

