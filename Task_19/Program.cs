// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
long num_len;
int n = 0;
int nn = 0;

Console.Write($"Введите число до 10 знаков: ");
long num = num_len = long.Parse(Console.ReadLine());

while (num_len > 0)
{
  num_len = num_len / 10;
  n++;
}

for (int i = 1; i <= n / 2; i++)
  if (num / Convert.ToInt32(Math.Pow(10, n - i)) % 10 == num % Convert.ToInt32(Math.Pow(10, i)) / Convert.ToInt32(Math.Pow(10, i - 1))) nn++;

if (n / 2 == nn)
  Console.WriteLine($"{num} -> Палиндром");
else
  Console.WriteLine($"{num} -> Не палиндром");