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


      Console.WriteLine("15. Ejercicio 15");
      Console.WriteLine("16. Salir");
      Console.Write("Seleccione el número del ejercicio que desea realizar: ");

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
    switch (numeroEjercicio)
    {
      case 1:
        new Exercise1().Operation1();
        break;
      case 2:
        new Exercise2().Operation2();
        break;
      // Repite esto para los 15 ejercicios...
      default:
        Console.WriteLine($"La clase para el ejercicio {numeroEjercicio} no está implementada aún.");
        break;
    }
  }
}
