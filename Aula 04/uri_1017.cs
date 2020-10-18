using System;

class MainClass {
  public static void Main (string[] args) {
    int tempo = int.Parse(Console.ReadLine());
    int velocidade = int.Parse(Console.ReadLine());

    double percorrido = velocidade * tempo;
    double combustivel = percorrido/12;

    Console.WriteLine ($"{combustivel:0.000}");
  }
}