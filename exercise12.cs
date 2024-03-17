using System;

class Exercise12
{
  public void Operation12()
  {
    Console.WriteLine("Vamos a encontrar el núm. más pequeño");

    double[] numeros = new double[5];
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Ingrese el número {i + 1}: ");
      if (!double.TryParse(Console.ReadLine(), out numeros[i]))
      {
        Console.WriteLine("¡Error! Ingrese un número válido.");
        return;
      }
    }

    double minimo = numeros[0];
    for (int i = 1; i < 5; i++)
    {
      if (numeros[i] < minimo)
      {
        minimo = numeros[i];
      }
    }

    Console.WriteLine($"El número más pequeño de los ingresados es: {minimo}");
  }
}
