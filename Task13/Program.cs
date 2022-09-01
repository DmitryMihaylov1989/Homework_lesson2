// напишите программу, которая выводит третью цифру
//  заданного числа или сообщает что третьей цифры нет 
Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99)
{
    Console.WriteLine((n   % 1000)/100);
}

else {
  Console.WriteLine("третьей цифры нет");
}

