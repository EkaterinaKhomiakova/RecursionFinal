// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N
// N=5->"1,2,3,4,5"
// N=6->"1,2,3,4,5,6"

string OutPutNumber(int Number)
{
  if (Number == 1)
    return 1.ToString();
  string Empty = String.Empty;
  return Empty + OutPutNumber(Number - 1) + "," + Number.ToString();
}

Console.Write("Задайте натуральное число: ");
int Number = int.Parse(Console.ReadLine());
Console.Write(OutPutNumber(Number));
