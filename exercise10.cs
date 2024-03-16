using System;

class Exercise10
{
  public void Operation10()
  {
    Console.WriteLine("Vamos a calcular la longitud de una palabra");

    Console.Write("Ingrese una palabra: ");
    string palabra = Console.ReadLine();

    int longitud = palabra.Length;


    Console.WriteLine($"La longitud de la palabra '{palabra}' es: {longitud}");
  }
}
