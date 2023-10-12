// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число A в целую степень B с помощью рекурсии
int Pow(int a, int b)
{
  if (b == 0) return 1;
  return a * Pow(a, b - 1);//A в степени B = A*A в степени(B-1)
}

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Pow(a, b));

