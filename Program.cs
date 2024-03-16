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
      Console.WriteLine("3. Ejercicio 3");
      Console.WriteLine("4. Ejercicio 4");
      Console.WriteLine("5. Ejercicio 5");
      Console.WriteLine("6. Ejercicio 6");
      Console.WriteLine("7. Ejercicio 7");
      Console.WriteLine("8. Ejercicio 8");
      Console.WriteLine("9. Ejercicio 9");
      Console.WriteLine("10. Ejercicio 10");
      Console.WriteLine("11. Ejercicio 11");
      Console.WriteLine("12. Ejercicio 12");
      Console.WriteLine("13. Ejercicio 13");
      Console.WriteLine("14. Ejercicio 14");
      Console.WriteLine("15. Ejercicio 15");
      Console.WriteLine("16. Salir");
      Console.Write("Seleccione el número del ejercicio que desea realizar: ");

      if (!int.TryParse(Console.ReadLine(), out opcion))
      {
        Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
        continue;
      }

      if (opcion >= 16)
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
      case 3:
        new Exercise3().Operation3();
        break;
      case 4:
        new Exercise4().Operation4();
        break;
       case 5:
        new Exercise5().Operation5();
        break;
      case 6:
        new Exercise6().Operation6();
        break;
      /*case 7:
        new Exercise7().Operation7();
        break;
      case 8:
        new Exercise8().Operation8();
        break;
      case 9:
        new Exercise9().Operation3();
        break;
      case 10:
        new Exercise10().Operation10();
        break;
      case 11:
        new Exercise11().Operation11();
        break;
      case 12:
        new Exercise12().Operation12();
        break;
      case 13:
        new Exercise13().Operation13();
        break;
      case 14:
        new Exercise14().Operation14();
        break;
      case 15:
        new Exercise15().Operation15();
        break; */
      default:
        Console.WriteLine($"La clase para el ejercicio {numeroEjercicio} no está implementada aún.");
        break;
    }
  }
}
