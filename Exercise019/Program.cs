// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число, чтобы проверить является ли оно палиндромом : ");

if (!int.TryParse(Console.ReadLine(), out int number) || number < 10000 || number > 99999)
{
  Console.WriteLine("Введено неверное число");
  return;
}
int reverse, sum = 0;
int palinDrom = number;
while (number > 0)
{
  reverse = number % 10;
  //Console.WriteLine(reverse);
  sum = (sum * 10) + reverse;
 // Console.WriteLine(sum);
  number = number / 10;
  //Console.WriteLine(number);
}
if (palinDrom == sum)
{
  Console.WriteLine($"Число {palinDrom} является палиндромом.");
}
else
{
  Console.WriteLine($"Число {palinDrom} не является палиндромом.");
}
Console.ReadKey();


