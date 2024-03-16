using System;
class Exercise1
{
  public void Operation1()
  {
    Console.WriteLine("Vamos a generar el cuadrado de un número");
    Console.Write("Ingrese un número: ");
    if (!double.TryParse(Console.ReadLine(), out double numero))
    {
      Console.WriteLine("¡Error! Ingrese un número válido.");
      return;
    }
    if (numero >= 0)
    {
      double resultado = Math.Pow(numero, 2);
      Console.WriteLine($"El cuadrado de {numero} es {resultado}");
    }
    else
    {
      Console.WriteLine("El número ingresado es negativo. No se puede elevar al cuadrado.");
    }
  }
}

