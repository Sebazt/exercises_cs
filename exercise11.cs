using System;

class Exercise11
{
  public void Operation11()
  {
    Console.WriteLine("Vamos a sacar el promedio de varios núms.");

    // Solicitar al usuario cuatro números
    double[] numeros = new double[4];
    for (int i = 0; i < 4; i++)
    {
      Console.Write($"Ingrese el número {i + 1}: ");
      if (!double.TryParse(Console.ReadLine(), out numeros[i]))
      {
        Console.WriteLine("¡Error! Ingrese un número válido.");
        return;
      }
    }

    double suma = 0;
    for (int i = 0; i < 4; i++)
    {
      suma += numeros[i];
    }
    double promedio = suma / 4;

    Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
  }
}
