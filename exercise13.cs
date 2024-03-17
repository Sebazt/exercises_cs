using System;

class Exercise13
{
  public void Operation13()
  {
    Console.WriteLine("Conteo de vocales");

    Console.Write("Ingrese una palabra: ");
    string palabra = Console.ReadLine();

    palabra = palabra.ToLower();

    int contadorVocales = 0;

    foreach (char letra in palabra)
    {
      if (EsVocal(letra))
      {
        contadorVocales++;
      }
    }

    Console.WriteLine($"El número de vocales en la palabra '{palabra}' es: {contadorVocales}");
  }

  private bool EsVocal(char letra)
  {
    return "aeiou".Contains(letra);
  }
}
