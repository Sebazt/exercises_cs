using System;

class Exercise5
{
  public void Operation5()
  {
    Console.WriteLine("Ingresa 1 número y te devolveré el día de la semana");

    Console.Write("Ingrese un número entre 1 y 7: ");
    if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 1 || numero > 7)
    {
      Console.WriteLine("¡Error! Ingrese un número válido entre 1 y 7.");
      return;
    }

    string diaSemana;
    switch (numero)
    {
      case 1:
        diaSemana = "Lunes";
        break;
      case 2:
        diaSemana = "Martes";
        break;
      case 3:
        diaSemana = "Miércoles";
        break;
      case 4:
        diaSemana = "Jueves";
        break;
      case 5:
        diaSemana = "Viernes";
        break;
      default:
        diaSemana = "No se trabaja fines de semana.";
        break;
    }

    Console.WriteLine($"El día de la semana correspondiente al número {numero} es: {diaSemana}");
  }
}
