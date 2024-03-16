using System;

class Exercise3
{
  public void Operation3()
  {
    Console.WriteLine("Vamos a calcular la raíz cuadrada o el cuadrado de un número");
    Console.Write("Ingrese un número: ");
    if (!double.TryParse(Console.ReadLine(), out double numero))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }

    double resultado;
    if (numero >= 0)
    {
      resultado = Math.Sqrt(numero);
      Console.WriteLine($"El número es positivo. Su raíz cuadrada es: {resultado}");
    }
    else
    {
      resultado = numero * numero;
      Console.WriteLine($"El número es negativo. Su cuadrado es: {resultado}");
    }
  }
}
