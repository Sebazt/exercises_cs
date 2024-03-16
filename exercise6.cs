using System;

class Exercise6
{
  public void Operation6()
  {
    Console.WriteLine("Para conocer tu impuesto, digita tu salario anual");

    // Solicitar al usuario su salario anual
    Console.Write("Ingrese su salario anual: ");
    if (!double.TryParse(Console.ReadLine(), out double salarioAnual) || salarioAnual < 0)
    {
      Console.WriteLine("¡Error! Ingrese un salario anual válido.");
      return;
    }

    double impuesto = 0;
    if (salarioAnual > 12000)
    {
      double excedente = salarioAnual - 12000;
      impuesto = excedente * 0.15;
      Console.WriteLine($"Su salario excede los 12000. El impuesto a pagar es: {impuesto}");
    }
    else
    {
      Console.WriteLine("Su salario no excede los 12000. No hay impuesto a pagar.");
    }
  }
}
