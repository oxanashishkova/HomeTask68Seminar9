// № 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


Console.WriteLine("Enter 1rst number: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
int numberN = int.Parse(Console.ReadLine());

int akkermanFunc = AkkCount(numberM, numberN);

Console.Write($"Ackkerman function = {akkermanFunc} ");

int AkkCount(int numberM, int numberN)
{
  if (numberM == 0) return numberN + 1;
  else if (numberN == 0) return AkkCount(numberM - 1, 1);
  else return AkkCount(numberM - 1, AkkCount(numberM, numberN - 1));
}

