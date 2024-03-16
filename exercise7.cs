using System;

class Exercise7
{
  public void Operation7()
  {
    Console.WriteLine("Vamos a calcular el residuo de la división");
    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double numero1))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }

    Console.Write("Ingrese el segundo número (distinto de cero): ");
    if (!double.TryParse(Console.ReadLine(), out double numero2) || numero2 == 0)
    {
      Console.WriteLine("¡Error! Ingrese un número válido distinto de cero.");
      return;
    }

    double residuo = numero1 % numero2;
    Console.WriteLine($"El residuo de la división de {numero1} entre {numero2} es: {residuo}");
  }
}
