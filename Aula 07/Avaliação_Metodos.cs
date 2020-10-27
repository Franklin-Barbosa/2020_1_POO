using System;

class MainClass {
  public static void Main (string[] args) { 
    Console.WriteLine("Digite um valor inteiro");
    int inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro valor inteiro");
    int fim = int.Parse(Console.ReadLine());

    long s = Intervalo(inicio, fim);
    Console.WriteLine($"A soma dos inteiros no intervalo digitado, é: {s}");
    Console.ReadKey();
  }
        
    public static long Intervalo(int inicio, int fim) {
      int n = fim - inicio + 1;
      return ((inicio + fim) * n) / 2;
  }
}