using System;

class Exercise8
{
  public void Operation8()
  {
    Console.WriteLine("Sumaremos núms pares del 1 al 50");

    int suma = 0;

    for (int i = 2; i <= 50; i += 2)
    {
      suma += i;
    }

    Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
  }
}
