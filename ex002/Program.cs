// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int m = EnterNumbs("Enter m: ");
int n = EnterNumbs("Enter n: ");

int FunctionAkkerman = Akkerman(m, n);

Console.Write($"Result of Function Akkerman = {FunctionAkkerman} ");
Console.WriteLine();

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int EnterNumbs(string arg) 
{
  Console.Write(arg);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

 