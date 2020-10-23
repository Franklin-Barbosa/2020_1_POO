using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o primeiro valor: ");
    double primeiro_valor = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor: ");
    double segundo_valor = double.Parse(Console.ReadLine());
    double c = Maior(primeiro_valor, segundo_valor);
    Console.WriteLine($"Maior valor é {c}");

  }
    public static double Maior(double x, double y) {
      return x > y ? x : y;
    }
}
    class Matematica { 
      public static double Maior(double x, double y) {           
        return x > y ? x : y;
    }
}