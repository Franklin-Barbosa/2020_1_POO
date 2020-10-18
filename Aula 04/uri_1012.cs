using System;

class MainClass {
  public static void Main (string[] args) {
    string x = Console.ReadLine();
    string[] valores = x.Split(' ');
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);
    double c = double.Parse(valores[2]);
    double triangulo = a * c / 2;
    double circulo = (c * c) * 3.14159;
    double trapezio = (a + b) / 2 * c;
    double quadrado = b * b;
    double retangulo = a * b;

    Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
    Console.WriteLine($"CIRCULO: {circulo:0.000}");
    Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
    Console.WriteLine($"QUADRADO: {quadrado:0.000}");
    Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}