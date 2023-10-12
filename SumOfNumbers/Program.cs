// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр
// 453->12
// 45->9
int SumDigital(int number)
{
  if (number == 0)
  {
    return number;
  }
  return number % 10 + SumDigital(number / 10);
}

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigital(number));
