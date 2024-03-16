using System;

class Exercise2
{
  public void Operation2()
  {
    Console.WriteLine("Ingresaremos dos números");

    // Solicitar al usuario dos números
    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double numero1))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }

    Console.Write("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double numero2))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }
    double resultado;
    
    if (numero1 > numero2)
    {
      resultado = numero1 * 2;
      Console.WriteLine($"El primer número es mayor. Su doble es: {resultado}");
    }
    else
    {
      resultado = numero2 * 3;
      Console.WriteLine($"El segundo número es mayor o igual. Su triple es: {resultado}");
    }
  }
}
