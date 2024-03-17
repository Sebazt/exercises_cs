using System;

class Exercise15
{
  public void Operation15()
  {
    Console.WriteLine("Vamos a verificar si un número está en el rango de 10 a 20.");

    Console.Write("Ingrese un número: ");
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }

    if (numero >= 10 && numero <= 20)
    {
      Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
    }
    else
    {
      Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
    }
  }
}
