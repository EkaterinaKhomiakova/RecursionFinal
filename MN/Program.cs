// Задайте значение M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N
// M=1; N=5->"1,2,3,4,5"
// M = 4; N=8->"4,5,6,7,8"

string OutPutNumber(int M, int N)
{
  if (M == N)
    return M.ToString();
  return OutPutNumber(M, N - 1) + "," + N.ToString();
}

Console.Write("Введите число M и N: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutPutNumber(numbers[0], numbers[1]));
