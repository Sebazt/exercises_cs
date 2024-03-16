using System;

class Exercise4
{
  public void Operation4()
  {
    Console.WriteLine("Vamos a calcular el perímetro de un circulo.");

    Console.Write("Ingrese el radio del círculo: ");
    if (!double.TryParse(Console.ReadLine(), out double radio) || radio < 0)
    {
      Console.WriteLine("¡Error! Ingrese un radio válido.");
      return;
    }
    double perimetro = 2 * Math.PI * radio;

    Console.WriteLine($"El perímetro del círculo con radio {radio} es: {perimetro}");
  }
}
