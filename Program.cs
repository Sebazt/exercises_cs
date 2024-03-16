using System;

class Program
{
  static void Main(string[] args)
  {
    int opcion;

    while (true)
    {
      Console.WriteLine("Menu:");
      Console.WriteLine("1. Ejercicio 1");
      Console.WriteLine("2. Ejercicio 2");
      // Repite esto para los 15 ejercicios...

      Console.WriteLine("15. Ejercicio 15");
      Console.WriteLine("16. Salir");
      Console.Write("Seleccione el número del ejercicio que desea ejecutar: ");

      if (!int.TryParse(Console.ReadLine(), out opcion))
      {
        Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
        continue;
      }

      if (opcion == 16)
      {
        Console.WriteLine("Saliendo del programa...");
        return;
      }

      if (opcion < 1 || opcion > 15)
      {
        Console.WriteLine("Ejercicio inválido. Por favor, seleccione un ejercicio válido.");
        continue;
      }

      EjecutarEjercicio(opcion);
    }
  }

  static void EjecutarEjercicio(int numeroEjercicio)
  {
    // Determinar qué clase corresponde al número de ejercicio
    switch (numeroEjercicio)
    {
      case 1:
        new Ejercicio1().RealizarOperacion();
        break;
      case 2:
        new Ejercicio2().RealizarOperacion();
        break;
      // Repite esto para los 15 ejercicios...
      default:
        Console.WriteLine($"La clase para el ejercicio {numeroEjercicio} no está implementada aún.");
        break;
    }
  }
}

class Ejercicio1
{
  public void RealizarOperacion()
  {
    Console.WriteLine("Ejercicio 1: Operación del ejercicio 1");
    // Lógica del ejercicio 1 aquí
  }
}

class Ejercicio2
{
  public void RealizarOperacion()
  {
    Console.WriteLine("Ejercicio 2: Operación del ejercicio 2");
    // Lógica del ejercicio 2 aquí
  }
}

// Clases para los otros ejercicios...
